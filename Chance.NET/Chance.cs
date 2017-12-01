using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanceNET
{
    public class Chance
    {
		int seed;
		Random rand;

		public Chance(int seed)
		{
			this.seed = seed;
			rand = new Random(seed);
		}

		public Chance() : this(Environment.TickCount)
		{

		}

		public int GetSeed()
		{
			return seed;
		}

		/// <summary>
		/// Generate a random boolean with a 50% chance of being true
		/// </summary>
		/// <returns></returns>
		public bool Bool()
		{
			return rand.NextDouble() < 0.5;
		}

		/// <summary>
		/// Generate a random boolean with a given likelihood of being true.
		/// </summary>
		/// <param name="likelihood">The chance to return true</param>
		/// <returns></returns>
		public bool Bool(double likelihood)
		{
			return rand.NextDouble() < likelihood;
		}

		/// <summary>
		/// Generate a random character
		/// </summary>
		/// <param name="pool"></param>
		/// <returns></returns>
		public char Char(string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()")
		{
			return PickOne(pool.ToCharArray());
		}
		
		/// <summary>
		/// Generate a random letter a-z, A-Z
		/// </summary>
		/// <returns></returns>
		public char Letter()
		{
			return Char("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		/// <summary>
		/// Generate a random string.
		/// </summary>
		/// <param name="length">The length of the string</param>
		/// <param name="pool">The pool of characters</param>
		/// <returns></returns>
		public string String(int length, string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()")
		{
			return new string(
				Enumerable.Repeat(pool, length)
					.Select(s => s[rand.Next(s.Length)])
					.ToArray()
				);
		}

		/// <summary>
		/// Generate a random hexadecimal string
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string Hex(int length)
		{
			const string pool = "0123456789abcdef";
			return String(length, pool);
		}

		public byte[] Hash(int length)
		{
			byte[] hash = new byte[length];
			rand.NextBytes(hash);
			return hash;
		}

		/// <summary>
		/// Generate a random syllable.
		/// </summary>
		/// <param name="length">The length of the syllable. The default is randomly picked to be either 2 or 3.</param>
		/// <returns></returns>
		public string Syllable(int? length = null)
		{
			const string consonants = "bcdfghjklmnprstvwz";
			const string vowels = "aeiou";
			const string any = "bcdfghjklmnprstvwzaeiou";

			char lastChar = '0';

			StringBuilder syllable = new StringBuilder();

			length = length ?? Integer(2, 4);

			for (int i = 0; i < length; i++)
			{
				if (i == 0)
				{
					// First character can be anything
					lastChar = Char(any);
				}
				else if (vowels.Contains(lastChar))
				{
					// Last character was a vowel, now we want a consonant
					lastChar = Char(consonants);
				}
				else
				{
					// Last character was a consonant, now we want a vowel
					lastChar = Char(vowels);
				}

				syllable.Append(lastChar);
			}

			return syllable.ToString();
		}

		/// <summary>
		/// Return a semi-pronounceable random (nonsense) word.
		/// </summary>
		/// <param name="syllables">Amount of syllables in the word. Default is to pick a random amount between 1 and 3</param>
		/// <param name="length">The maximum length of the generated string</param>
		/// <param name="capitalize">Capitalize the first letter</param>
		/// <returns></returns>
		public string Word(int? syllables = null, int? length = null, bool capitalize = false)
		{
			StringBuilder word = new StringBuilder();

			syllables = syllables ?? Integer(1, 4);

			for (int i = 0; i < syllables; i++)
			{
				word.Append(Syllable());
			}

			if (capitalize)
			{
				word[0] = char.ToUpper(word[0]);
			}

			int wordLength = length ?? word.Length;

			return word.ToString().Substring(0, wordLength);
		}

		/// <summary>
		/// Return a random sentence populated by semi-pronounceable random (nonsense) words.
		/// </summary>
		/// <param name="words">The amount of the words of the sentence. Default is to pick a random amount between 12 and 19</param>
		/// <param name="capitalize">Capitalize the first letter of the sentence.</param>
		/// <param name="punctuation">Whether to put punctuation at the end of the sentence.</param>
		/// <param name="punctuationMark">The character to use as punctuation</param>
		/// <returns></returns>
		public string Sentence(int? words = null, int? length = null,
		                       bool capitalize = false, bool punctuation = false ,char punctuationMark = '.')
		{
			StringBuilder sentence = new StringBuilder();

			int wordCount = words ?? Integer(12, 19);

			for (int i = 0; i < wordCount; i++)
			{
				if (i > 0)
					sentence.Append(' ');
				sentence.Append(Word());
			}

			if (capitalize)
			{
				sentence[0] = char.ToUpper(sentence[0]);
			}

			int sentenceLength = length ?? sentence.Length;

			string result = sentence.ToString().Substring(0, sentenceLength);

			if (punctuation)
			{
				result += punctuationMark;
			}

			return result;
		}

		public string Paragraph(int? sentences = null, int? words = null, int? length = null)
		{
			StringBuilder paragraph = new StringBuilder();

			int sentenceCount = sentences ?? Integer(3, 8);
			int wordCount = 0;

			char lastPunctuation = '.';
			for (int i = 0; i < sentenceCount; i++)
			{
				if (i != 0)
				{
					paragraph.Append(' ');
				}

				bool capitalize = lastPunctuation == '.';
				lastPunctuation = (i != sentenceCount - 1 && Bool(0.4)) ? ',' : '.';

				string sentence = Sentence(punctuation: true, punctuationMark: lastPunctuation, capitalize: capitalize);
				int sentenceWords = sentence.Split(' ').Length;

				if (words != null && (wordCount + sentenceWords) > words)
				{
					sentence = Sentence(punctuation: true, punctuationMark: lastPunctuation,
					                    words: words - wordCount);
				}

				if (length != null && (paragraph.Length + sentence.Length) > length)
				{
					sentence = Sentence(punctuation: true, punctuationMark: lastPunctuation,
					                    length : length - paragraph.Length, capitalize: capitalize);
				}


				paragraph.Append(sentence);
			}


			return paragraph.ToString();
         }

		/// <summary>
		/// Generate a random non-negative integer between min (inclusive) and max (exlusive)
		/// </summary>
		/// <param name="min">Inclusive lower bound</param>
		/// <param name="max">Exclusive upper bound</param>
		/// <returns></returns>
		public int Integer(int min = int.MinValue, int max = int.MaxValue)
		{
			return rand.Next(min, max);
		}

		/// <summary>
		/// Generate a random long number
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public long Long(long min = long.MinValue, long max = long.MaxValue)
		{
			byte[] buf = new byte[8];
			rand.NextBytes(buf);
			long longRand = BitConverter.ToInt64(buf, 0);
			return (Math.Abs(longRand % (max - min)) + min);
		}

		/// <summary>
		/// Generate a random non-negative integer that is less than the given value.
		/// </summary>
		/// <returns>The natural.</returns>
		/// <param name="max">Max.</param>
		public int Natural(int max = int.MaxValue)
		{
			return rand.Next(max);
		}

		/// <summary>
		/// Generate a random double between 0.0 (inclusive) and 1.0 (exclusive)
		/// </summary>
		/// <returns></returns>
		public double Double()
		{
			return rand.NextDouble();
		}

		/// <summary>
		/// Generate a random double between min (inclusive) and max (exclusive)
		/// </summary>
		/// <returns></returns>
		public double Double(double min, double max)
		{
			return min + rand.NextDouble() * (max - min);
		}

		public byte Byte()
		{
			byte[] buf = new byte[1];
			rand.NextBytes(buf);
			return buf[0];
		}

		public int Age(AgeRange range = AgeRange.Any)
		{
			switch (range)
			{
				case AgeRange.Any:
					return Natural(100);

				case AgeRange.Child:
					return Integer(0, 13);

				case AgeRange.Teen:
					return Integer(13, 20);

				case AgeRange.Adult:
					return Integer(18, 65);

				case AgeRange.Senior:
					return Integer(60, 100);

				default:
					goto case AgeRange.Any;
			}
		}

		public DateTime Birthday(AgeRange range = AgeRange.Any)
		{
			return Date(year: DateTime.Now.Year - Age());
		}

		public string FirstName(Gender? gender = null)
		{
			switch (gender)
			{
				case ChanceNET.Gender.Male:
					return PickOne(Data.FirstNames.Male);

				case ChanceNET.Gender.Female:
					return PickOne(Data.FirstNames.Female);

				default:
					return PickOne(Data.FirstNames.Any);
			}
		}

		public Gender Gender()
		{
			return Bool() ? ChanceNET.Gender.Male : ChanceNET.Gender.Female;
		}

		public string LastName()
		{
			return PickOne(Data.LastNames);
		}

		public string NamePrefix(Gender? gender = null)
		{
			switch (gender)
			{
				case ChanceNET.Gender.Male:
					return PickOne(Data.Prefixes.Male);

				case ChanceNET.Gender.Female:
					return PickOne(Data.Prefixes.Female);

				default:
					return PickOne(Data.Prefixes.Any);
			}
		}

		public string NameSuffix()
		{
			return PickOne(Data.Suffixes);
		}

		public string FullName(Gender? gender = null, bool prefix = false,
			bool middle = false, bool middleInitial = false, bool suffix = false)
		{
			StringBuilder name = new StringBuilder();

			if (prefix)
			{
				name.Append(NamePrefix(gender));
				name.Append(' ');
			}

			name.Append(FirstName(gender));
			name.Append(' ');

			if (middle && middleInitial)
			{
				name.Append(char.ToUpper(Letter()));
				name.Append(". ");
			}
			else if (middle)
			{
				name.Append(FirstName(gender));
				name.Append(' ');
			}

			name.Append(LastName());

			if (suffix)
			{
				name.Append(' ');
				name.Append(NameSuffix());
			}

			return name.ToString();
		}

		/// <summary>
		/// Generate a random Social Security Number
		/// </summary>
		/// <param name="dashes"></param>
		/// <param name="ssnFour"></param>
		/// <returns></returns>
		public string SSN(bool dashes = true, bool ssnFour = false)
		{
			const string pool = "1234567890";

			if (ssnFour)
			{
				return String(4, pool);
			}

			string dash = dashes ? "-" : "";

			StringBuilder ssn = new StringBuilder();

			ssn.Append(String(3, pool));
			ssn.Append(dash);
			ssn.Append(String(2, pool));
			ssn.Append(dash);
			ssn.Append(String(4, pool));

			return ssn.ToString();
		}

		public string AndroidId()
		{
			return "APA91" + String(178, "0123456789abcefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_");
		}

		public string AppleToken()
		{
			return String(64, "abcdef1234567890");
		}

		/// <summary>
		/// Windows Phone 8 ANID2
		/// </summary>
		/// <returns></returns>
		public string Wp8ANID2()
		{
			return Hex(32);
		}

		/// <summary>
		/// Windows Phone 7 ANID
		/// </summary>
		/// <returns></returns>
		public string Wp7ANID()
		{
			return "A=" + Guid().Replace("-", "").ToUpper()
				+ "&E=" + Hex(3)
				+ "&W=" + Integer(0, 10);
		}

		public string BbPin()
		{
			return Hex(8);
		}

		public string Guid(GuidVersion version = GuidVersion.V4)
		{
			const string pool = "abcdef1234567890";
			const string variantPool = "ab89";

			StringBuilder guid = new StringBuilder();

			guid.Append(String(8, pool));
			guid.Append('-');
			guid.Append(String(4, pool));
			guid.Append('-');

			guid.Append((int)version);
			guid.Append(String(3, pool));
			guid.Append('-');

			guid.Append(String(1, variantPool));
			guid.Append(String(3, pool));
			guid.Append('-');

			guid.Append(String(12, pool));

			return guid.ToString();
		}

		public string Email(int? length = null, string domain = null, string tld = null)
		{
			return Word(length: length) + "@" + (domain ?? Domain(tld));
		}

		/// <summary>
		/// Generate a random domain name
		/// </summary>
		/// <param name="tld"></param>
		/// <returns></returns>
		public string Domain(string tld = null)
		{
			return Word() + "." + (tld ?? Tld());
		}

		/// <summary>
		/// Generate a random Top-Level Domain. (com, net, org etc.)
		/// </summary>
		/// <returns></returns>
		public string Tld()
		{
			return PickOne(Data.TLDs);
		}

		/// <summary>
		/// Generate a random Facebook id, aka fbid.
		/// <para>NOTE: At the moment (Sep 2017), Facebook ids are "numeric strings" of length 16. 
		/// However, Facebook Graph API documentation states that it is extremely likely to change over time.</para>
		/// </summary>
		/// <returns></returns>
		public string FbId()
		{
			return "10000" + String(11, "1234567890");
		}


		public string GoogleAnalytics()
		{
			string account = Pad(Natural(max: 999999), 6);
			string property = Pad(Natural(max: 99), 2);
			return "UA-" + account + "-" + property;
		}

		public DateTime Date(int? year = null, Month? month = null, int? day = null, int? minYear = null, int? maxYear = null)
		{
			DateTime randomDate = new DateTime(minYear ?? 1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime maxDate = new DateTime(maxYear ?? 9999, 0, 0);

			long ticksToAdd = Long(
				min: 0,
				max: maxDate.Ticks - randomDate.Ticks
				);

			randomDate = randomDate.AddTicks(ticksToAdd);

			int randYear = year ?? randomDate.Year;
			int randMonth = (int?)month ?? randomDate.Month;
			int randDay = day ?? randomDate.Day;

			return new DateTime(randYear, randMonth, randDay, randomDate.Hour, randomDate.Minute, randomDate.Second, randomDate.Millisecond);
		}

		public CoinSide Coin()
		{
			return Bool() ? CoinSide.Heads : CoinSide.Tails;
		}

		/// <summary>
		/// Pad a number with some string until it reaches a desired width.
		/// </summary>
		/// <param name="number"></param>
		/// <param name="length">Length of the final string</param>
		/// <param name="padder"></param>
		/// <returns></returns>
		public static string Pad(int number, int length, char padder = '0')
		{
			StringBuilder num = new StringBuilder(number);

			while (num.Length < length)
			{
				num.Insert(0, padder);
			}

			return num.ToString();
		}

		public int D4()
		{
			return Integer(1, 5);
		}

		public int D6()
		{
			return Integer(1, 7);
		}

		public int D8()
		{
			return Integer(1, 9);
		}

		public int D10()
		{
			return Integer(1, 11);
		}

		public int D12()
		{
			return Integer(1, 13);
		}

		public int D20()
		{
			return Integer(1, 21);
		}

		public int D30()
		{
			return Integer(1, 31);
		}

		public int D100()
		{
			return Integer(1, 101);
		}

		/// <summary>
		/// Provide any function that generates random stuff (usually another Chance function) 
		/// and a number and N() will generate a list of items with a length matching the length you specified.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="length"></param>
		/// <param name="func"></param>
		/// <returns></returns>
		public List<T> N<T>(int length, Func<T> func)
		{
			List<T> list = new List<T>();
			for (int i = 0; i < length; i++)
			{
				list.Add(func());
			}
			return list;
		}

		/// <summary>
		/// Get a random element with equal probability
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns></returns>
		public T PickOne<T>(IEnumerable<T> list)
		{
			int index = rand.Next(0, list.Count());
			return list.ElementAt(index);
		}

		public IEnumerable<T> PickSet<T>(IEnumerable<T> list, int count = 1)
		{
			return Shuffle(list).Take(count);
		}

		/// <summary>
		/// Shuffle the specified list.
		/// </summary>
		/// <returns>The shuffle.</returns>
		/// <param name="list">List.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public IEnumerable<T> Shuffle<T>(IEnumerable<T> list)
		{
			return list.OrderBy(e => Integer());
		}
	}
}

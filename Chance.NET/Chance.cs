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

			for (int i = 0; i < sentenceCount; i++)
			{
				if (i != 0)
				{
					paragraph.Append(' ');
				}

				char punctuation = (i != sentenceCount - 1 && Bool(0.4)) ? ',' : '.';

				string sentence = Sentence(punctuation: true, punctuationMark: punctuation);
				int sentenceWords = sentence.Split(' ').Length;

				if (words != null && (wordCount + sentenceWords) > words)
				{
					sentence = Sentence(punctuation: true, punctuationMark: punctuation,
					                    words: words - wordCount);
				}

				if (length != null && (paragraph.Length + sentence.Length) > length)
				{
					sentence = Sentence(punctuation: true, punctuationMark: punctuation,
					                    length : length - paragraph.Length);
				}


				paragraph.Append(sentence);
			}


			return paragraph.ToString();
         }
		
		/// <summary>
		/// Generate a random integer
		/// </summary>
		/// <returns></returns>
		public int Integer()
		{
			return rand.Next(int.MinValue, int.MaxValue);
		}

		/// <summary>
		/// Generate a random integer that is less than the given value
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public int Integer(int max)
		{
			return rand.Next(int.MinValue, max);
		}

		/// <summary>
		/// Generate a random non-negative integer between min (inclusive) and max (exlusive)
		/// </summary>
		/// <param name="min">Inclusive lower bound</param>
		/// <param name="max">Exclusive upper bound</param>
		/// <returns></returns>
		public int Integer(int min, int max)
		{
			return rand.Next(min, max);
		}

		/// <summary>
		/// Generate a random non-negative integer
		/// </summary>
		/// <returns>The natural.</returns>
		public int Natural()
		{
			return rand.Next();
		}

		/// <summary>
		/// Generate a random non-negative integer that is less than the given value.
		/// </summary>
		/// <returns>The natural.</returns>
		/// <param name="max">Max.</param>
		public int Natural(int max)
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

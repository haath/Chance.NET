using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChanceNET
{
    public class Chance
    {
		protected int seed { get; private set; }
		protected virtual Random rand { get; }

		public Chance(int seed)
		{
			this.seed = seed;
			rand = new Random(seed);
		}

		public Chance() : this(Environment.TickCount)
		{

		}

		public Chance(string seed)
		{
			this.seed = 0;

			for (int i = 0; i < seed.Length; i++)
			{
				this.seed = (int)seed[i] + (this.seed << 6) + (this.seed << 16) - this.seed;
			}

			rand = new Random(this.seed);
		}

		public int GetSeed()
		{
			return seed;
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
			return rand.Next(0, max);
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

		/// <summary>
		/// Return a normally-distributed random variate.
		/// </summary>
		/// <returns></returns>
		public double Normal()
		{
			double s2 = 1.0 / 36;
			double m = 0.5;

			double res;

			do
			{
				double x1 = Double();
				double x2 = Double();

				double sqrt = Math.Sqrt(-2 * s2 * Math.Log(x1));
				double cos = Math.Cos(2 * Math.PI * x2);

				res = sqrt * cos + m;
			}
			while (res < 0 || res >= 1.0);

			return res;
		}

		/// <summary>
		/// Return a normally-distributed value between min (inclusive) and max (exclusive).
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public double Normal(double min, double max)
		{
			return min + Normal() * (max - min);
		}

		/// <summary>
		/// Return a normally-distributed value between min (inclusive) and max (exclusive).
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public int Normal(int min, int max)
		{
			return (int)Math.Floor(min + Normal() * (max - min));
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
		/// Generate a random boolean with a given likelihood of being true, between 0.0 and 1.0
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

		public char Alphanumeric()
		{
			return Char("abcdefghijklmnopqrstuvwxyz0123456789");
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

			syllables = syllables ?? Integer(1, 5);

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
		/// Return a random Klout score. Range 1-99.
		/// <para>https://klout.com/home</para>
		/// </summary>
		/// <returns>The klout.</returns>
		public int Klout()
		{
			return Integer(1, 100);
		}

		public byte Byte()
		{
			return Hash(1)[0];
		}

		public int Age(AgeRanges range = AgeRanges.Any)
		{
			if (range == AgeRanges.Any)
				return Natural(100);

			Dictionary<int, double> ranges = new Dictionary<int, double>();

			if (range.HasFlag(AgeRanges.Child))
			{
				ranges.Add(Integer(0, 13), 13);
			}
			if (range.HasFlag(AgeRanges.Teen))
			{
				ranges.Add(Integer(13, 20), 7);
			}
			if (range.HasFlag(AgeRanges.Adult))
			{
				ranges.Add(Integer(18, 65), 47);
			}
			if (range.HasFlag(AgeRanges.Senior))
			{
				ranges.Add(Integer(60, 100), 40);
			}

			return Weighted(ranges);
		}

		public DateTime Birthday(AgeRanges range = AgeRanges.Any)
		{
			return Date(year: DateTime.Now.Year - Age(range));
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
			Person person = Person(gender: gender);
			return person.FullName(prefix, middle, middleInitial, suffix);
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

		public Person Person(AgeRanges ageRange = AgeRanges.Any, Gender? gender = null)
		{
			return new Person(this, ageRange, gender);
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

		/// <summary>
		/// BlackBerry pin.
		/// </summary>
		/// <returns>The pin.</returns>
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

		/// <summary>
		/// Generate a random e-mail
		/// </summary>
		/// <returns>The email.</returns>
		/// <param name="length">Length.</param>
		/// <param name="domain">Domain.</param>
		/// <param name="tld">Tld.</param>
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

		public string Hashtag()
		{
			return "#" + Word();
		}

		/// <summary>
		/// Generate a ranomd IPv4 address.
		/// <para>Optionally, you may also provide a subnet in the known form "192.168.1.0/24" to have the generated IP belong to that subnet.</para>
		/// </summary>
		/// <param name="subnet"></param>
		/// <returns></returns>
		public IPAddress IP(string subnet = null)
		{
			StringBuilder ip = new StringBuilder();

			byte[] p = new byte[4];
			p[0] = (byte)Integer(min: 1, max: 255);
			p[1] = (byte)Natural(max: 256);
			p[2] = (byte)Natural(max: 256);
			p[3] = (byte)Integer(min: 1, max: 255);

			if (subnet != null)
			{
				Match m = Regex.Match(subnet, @"^(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})/(\d{1,2})$");

				byte[] sp = new byte[4];
				sp[0] = byte.Parse(m.Groups[1].Value);
				sp[1] = byte.Parse(m.Groups[2].Value);
				sp[2] = byte.Parse(m.Groups[3].Value);
				sp[3] = byte.Parse(m.Groups[4].Value);
				int bits = int.Parse(m.Groups[5].Value);

				int bit = 0;
				byte mask = 1 << 7;

				while (bits-- > 0)
				{
					p[bit / 8] = (byte)((p[bit / 8] & ~mask) | (sp[bit / 8] & mask));

					mask = (byte)(mask >> 1);
					if (mask == 0)
						mask = 1 << 7;

					bit++;
				}
			}

			ip.Append(p[0]);
			ip.Append('.');
			ip.Append(p[1]);
			ip.Append('.');
			ip.Append(p[2]);
			ip.Append('.');
			ip.Append(p[3]);

			return IPAddress.Parse(ip.ToString());
		}

		/// <summary>
		/// Generate a random IPv6 address.
		/// </summary>
		/// <returns>The v6.</returns>
		public IPAddress IPv6()
		{
			StringBuilder ipv6 = new StringBuilder();

			for (int i = 0; i < 8; i++)
			{
				if (i != 0)
					ipv6.Append(':');
				ipv6.Append(Hex(4));
			}

			return IPAddress.Parse(ipv6.ToString());
		}

		/// <summary>
		/// Generate a random MAC address.
		/// </summary>
		/// <returns>The mac.</returns>
		public string MAC()
		{
			StringBuilder mac = new StringBuilder();

			mac.Append(Hex(2).ToUpper());
			mac.Append(':');
			mac.Append(Hex(2).ToUpper());
			mac.Append(':');
			mac.Append(Hex(2).ToUpper());
			mac.Append(':');
			mac.Append(Hex(2).ToUpper());
			mac.Append(':');
			mac.Append(Hex(2).ToUpper());
			mac.Append(':');
			mac.Append(Hex(2).ToUpper());

			return mac.ToString();
		}

		/// <summary>
		/// Generate a random MD5 hash.
		/// </summary>
		/// <returns>The MD.</returns>
		public byte[] MD5()
		{
			return Hash(12);
		}

		/// <summary>
		/// Generate a random SHA1 hash.
		/// </summary>
		/// <returns>The SHA.</returns>
		public byte[] SHA1()
		{
			return Hash(20);
		}

		/// <summary>
		/// Generate a random SHA256 hash.
		/// </summary>
		/// <returns>The 256.</returns>
		public byte[] SHA256()
		{
			return Hash(32);
		}

		/// <summary>
		/// Generate a random SHA512 hash.
		/// </summary>
		/// <returns>The 512.</returns>
		public byte[] SHA512()
		{
			return Hash(64);
		}

		/// <summary>
		/// Get a random profession name.
		/// </summary>
		/// <returns>The profession.</returns>
		/// <param name="rank">If set to <c>true</c> the name will be preceded by a rank.</param>
		public string Profession(bool rank = false)
		{
			if (rank)
			{
				return PickOne(Data.Professions.Ranks) + " " + PickOne(Data.Professions.Names);
			}
			else
			{
				return PickOne(Data.Professions.Names);
			}
		}

		/// <summary>
		/// Return a URL to a random avatar from Gravatar.
		/// </summary>
		/// <param name="defaultType"></param>
		/// <returns></returns>
		public string Avatar(GravatarDefaults? defaultType = null)
		{
			StringBuilder avatar = new StringBuilder("https://www.gravatar.com/avatar/");

			avatar.Append(BitConverter.ToString(MD5()).Replace("-", string.Empty).ToLower());

			if (defaultType != null)
			{
				avatar.Append("?d=");
				avatar.Append(defaultType.ToString().ToLower());
			}

			return avatar.ToString();
		}

		/// <summary>
		/// Generate a random color in Hex format.
		/// </summary>
		/// <returns></returns>
		public string Color(byte? red = null, byte? green = null, byte? blue = null)
		{
			byte[] color = new byte[3];
			color[0] = red ?? Byte();
			color[1] = green ?? Byte();
			color[2] = blue ?? Byte();
			return "#" + BitConverter.ToString(color).Replace("-", string.Empty);
		}

		/// <summary>
		/// Returns the name of a random color.
		/// </summary>
		/// <returns></returns>
		public string ColorName()
		{
			return PickOne(Data.ColorNames);
		}

		/// <summary>
		/// Get a random company name.
		/// </summary>
		/// <returns>The company.</returns>
		public string Company()
		{
			return PickOne(Data.Companies);
		}

		/// <summary>
		/// Generate a random twitter username.
		/// </summary>
		/// <returns>The twitter.</returns>
		public string Twitter()
		{
			return "@" + Word();
		}

		/// <summary>
		/// Generate a random IPEndPoint which is a pair of an IP and a port.
		/// </summary>
		/// <returns>The point.</returns>
		/// <param name="subnet">Subnet.</param>
		/// <param name="port">Port.</param>
		public IPEndPoint EndPoint(string subnet = null, int? port = null)
		{
			return new IPEndPoint(IP(subnet), port ?? Port());
		}

		public string Url(string protocol = null, string domain = null, 
		                  string path = null, string extension = null)
		{
			protocol = protocol ?? "http";
			domain = domain ?? Domain();
			path = path ?? Word();
			extension = extension ?? FileExtension();

			return protocol + "://" + domain + "/" + path + "." + extension;
		}

		/// <summary>
		/// Generate a random valid port number.
		/// </summary>
		/// <returns>The port.</returns>
		public int Port()
		{
			return Natural(65536);
		}

		/// <summary>
		/// Generate a random altitude.
		/// </summary>
		/// <returns>The altitude.</returns>
		public double Altitude()
		{
			return Double(0, 8849);
		}

		/// <summary>
		/// Generate a random US area code.
		/// </summary>
		/// <returns>The code.</returns>
		public string AreaCode(bool parentheses = true)
		{
			StringBuilder code = new StringBuilder();

			if (parentheses)
				code.Append('(');
			code.Append(Integer(2, 10));
			code.Append(Integer(0, 9));
			code.Append(Integer(0, 10));
			if (parentheses)
				code.Append(')');

			return code.ToString();
		}

		/// <summary>
		/// Generate a random city name
		/// </summary>
		/// <returns></returns>
		public string City()
		{
			return Capitalize(Word(syllables: 3));
		}

		/// <summary>
		/// Generate a random latitude.
		/// </summary>
		/// <returns></returns>
		public double Latitude(double min = -90, double max = 90)
		{
			return Double(min, max);
		}

		/// <summary>
		/// Generate a random longitude.
		/// </summary>
		/// <returns></returns>
		public double Longitude(double min = -180, double max = 180)
		{
			return Double(min, max);
		}

		public Location Location()
		{
			double lat = Latitude();
			double lng = Longitude();
			return new Location(lat, lng);
		}

		/// <summary>
		/// Given a geographical location and a range in meters, generate a new random location that is within the given range of the given location.
		/// </summary>
		/// <param name="centerLat"></param>
		/// <param name="centerLng"></param>
		/// <param name="range">The range in meters.</param>
		/// <returns></returns>
		public Location Location(double centerLat, double centerLng, double range)
		{
			if (range <= 0)
			{
				throw new ArgumentOutOfRangeException("range needs to be positive.");
			}
			throw new NotImplementedException();
		}

		public Location Location(Location center, double range)
		{
			return Location(center.Latitude, center.Longitude, range);
		}

		/// <summary>
		/// Generate random coordinates, which are latitude and longitude, comma separated.
		/// </summary>
		/// <returns></returns>
		public string Coordinates(double latMin = -90, double latMax = 90, double lngMin = -180, double lngMax = 180)
		{
			return Latitude(latMin, latMax) + ", " + Longitude(lngMin, lngMax);
		}

		/// <summary>
		/// Return a random country.
		/// </summary>
		/// <returns></returns>
		public WorldCountry Country()
		{
			return PickOne(Data.Countries);
		}

		/// <summary>
		/// Get a random US state.
		/// </summary>
		/// <returns>The state.</returns>
		public USState State()
		{
			return PickOne(Data.States);
		}

		/// <summary>
		/// Generate a random depth, in meters. Depths are always negative
		/// </summary>
		/// <returns></returns>
		public double Depth(double min = -10994, double max = 0)
		{
			return Double(min, max);
		}

		/// <summary>
		/// Generate a random geohash.
		/// <para>http://en.wikipedia.org/wiki/Geohash</para>
		/// </summary>
		/// <returns></returns>
		public string Geohash(int length = 7)
		{
			const string pool = "0123456789bcdefghjkmnpqrstuvwxyz";
			return String(length, pool);
		}

		/// <summary>
		/// Generate a random phone.
		/// <para>Conforms to NANP for a proper US phone number.</para>
		/// </summary>
		/// <param name="areaCode"></param>
		/// <param name="formatted"></param>
		/// <returns></returns>
		public string Phone(string areaCode = null, bool formatted = true)
		{
			return PhoneUS(areaCode, formatted);
		}

		string PhoneUS(string areaCode = null, bool formatted = true)
		{
			StringBuilder phone = new StringBuilder();

			string code = areaCode ?? AreaCode(false);

			if (formatted) phone.Append('(');
			phone.Append(code);
			if (formatted) phone.Append(") ");

			// exchange
			phone.Append(Integer(2, 10));
			phone.Append(Natural(max: 10));
			phone.Append(Natural(max: 10));
			if (formatted) phone.Append(' ');

			// subscriber
			phone.Append(Integer(1000, 10000));

			return phone.ToString();
		}

		/// <summary>
		/// Return a Canadian Postal code. Returned postal code is valid with respect to the Postal District (first character) and format only.
		/// </summary>
		/// <returns></returns>
		public string Postal()
		{
			StringBuilder postal = new StringBuilder();

			//pd
			postal.Append(Char("XVTSRPNKLMHJGECBA"));

			//fsa
			postal.Append(Natural(max: 10));
			postal.Append(char.ToUpper(Alphanumeric()));

			postal.Append(' ');

			// ldu
			postal.Append(Natural(max: 10));
			postal.Append(char.ToUpper(Alphanumeric()));
			postal.Append(Natural(max: 10));

			return postal.ToString();
		}

		/// <summary>
		/// Returns a random US-valid Zip Code.
		/// </summary>
		/// <returns></returns>
		public string Zip()
		{
			Dictionary<string, double> codeRanges = new Dictionary<string, double>();

			foreach (USState state in Data.States)
			{
				string[] ranges = state.ZipCodes.Split(',');
				foreach (string stateRange in ranges)
				{
					string[] stateminmax = stateRange.Split('-');

					if (stateminmax.Length == 1)
					{
						codeRanges.Add(stateRange, 1);
					}
					else
					{
						int min = int.Parse(stateminmax[0]);
						int max = int.Parse(stateminmax[1]);

						codeRanges.Add(stateRange, max - min);
					}
				}
			}


			string range = Weighted(codeRanges);

			string[] minmax = range.Split('-');
			int code;

			if (minmax.Length == 1)
			{
				code = int.Parse(range);
			}
			else
			{
				int min = int.Parse(minmax[0]);
				int max = int.Parse(minmax[1]);

				code = Integer(min, max + 1);
			}

			return Pad(code, 5);
		}

		public string Street(bool shortSuffix = true)
		{
			StringBuilder street = new StringBuilder();

			street.Append(Capitalize(Word()));
			street.Append(' ');

			street.Append(StreetSuffix(shortSuffix));

			return street.ToString();
		}

		/// <summary>
		/// Get a random street suffix
		/// </summary>
		/// <returns>The suffix.</returns>
		/// <param name="abbreviation">If set to <c>true</c> the abbreviation will be returned.</param>
		public string StreetSuffix(bool abbreviation = false)
		{
			if (abbreviation)
			{
				return PickOne(Data.StreetSuffixes.Abbreviations) + ".";
			}
			else
			{
				return PickOne(Data.StreetSuffixes.Names);
			}
		}

		/// <summary>
		/// Generate a random address with a street name and number.
		/// </summary>
		/// <returns>The address.</returns>
		/// <param name="numberFirst">If set to <c>true</c> the number will be before the street name.</param>
		/// <param name="shortStreetSuffix">If set to <c>true</c> the street suffix will be abbreviated.</param>
		/// <param name="minNumber">Minimum number.</param>
		/// <param name="maxNumber">Max number.</param>
		public string Address(bool numberFirst = true, bool shortStreetSuffix = true, int minNumber = 5, int maxNumber = 2000)
		{
			int number = Integer(minNumber, maxNumber + 1);
			if (numberFirst)
			{
				return number + " " + Street(shortStreetSuffix);
			}
			else
			{
				return Street(shortStreetSuffix) + " " + number;
			}
		}

		/// <summary>
		/// Returns either 'am' or 'pm'.
		/// </summary>
		/// <returns></returns>
		public string AmPm()
		{
			return Bool() ? "am" : "pm";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="year"></param>
		/// <param name="month"></param>
		/// <param name="day"></param>
		/// <param name="minYear"></param>
		/// <param name="maxYear"></param>
		/// <returns></returns>

		public DateTime Date(int? year = null, Month? month = null, int? day = null, int? minYear = null, int? maxYear = null)
		{
			DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			DateTime randomDate = new DateTime(minYear ?? 1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime maxDate = new DateTime(maxYear ?? 9999, 1, 1);

			TimeSpan range = maxDate - randomDate;
			TimeSpan toAdd = new TimeSpan((long)(Double() * range.Ticks));
			
			randomDate += toAdd;

			int randYear = year ?? randomDate.Year;
			int randMonth = (int?)month ?? randomDate.Month;
			int randDay = day ?? randomDate.Day;

			return new DateTime(randYear, randMonth, randDay, randomDate.Hour, randomDate.Minute, randomDate.Second, randomDate.Millisecond, DateTimeKind.Utc);
		}

		/// <summary>
		/// Hammertime is the name given to a Unix time with milliseconds. Which is the same as saying the number of milliseconds since 1970. 
		/// It has finer granularity than a normal Unix timestamp and thus is often used in realtime applications.
		/// </summary>
		/// <returns></returns>
		public long HammerTime()
		{
			DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

			return (long)(Date() - UnixEpoch).TotalMilliseconds;
		}

		/// <summary>
		/// Generate a random timestamp. This is a standard Unix time, so a random number of seconds since January 1, 1970.
		/// </summary>
		/// <returns></returns>
		public long Timestamp()
		{
			DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

			return (long)(Date() - UnixEpoch).TotalSeconds;
		}

		/// <summary>
		/// Generate a random hour.
		/// <para>By default, returns an hour from 1 to 12 for a standard 12-hour clock.</para>
		/// </summary>
		/// <param name="twentyFour"></param>
		/// <returns></returns>
		public int Hour(bool twentyFour = false)
		{
			return twentyFour ? Natural(max: 24) : Integer(1, 13);
		}

		/// <summary>
		/// Generate a random minute from 0 to 59. Idea is for generating a clock time.
		/// </summary>
		/// <returns></returns>
		public int Minute()
		{
			return Natural(max: 60);
		}

		/// <summary>
		/// Generate a random second from 0 to 59. Idea is for generating a clock time.
		/// </summary>
		/// <returns></returns>
		public int Second()
		{
			return Natural(max: 60);
		}

		/// <summary>
		/// Generate a random millisecond from 0 to 999. Idea is for generating a clock time.
		/// </summary>
		/// <returns></returns>
		public int Millisecond()
		{
			return Natural(max: 1000);
		}

		/// <summary>
		/// Generate a random month.
		/// </summary>
		/// <returns></returns>
		public Month Month(Month min = ChanceNET.Month.January, Month max = ChanceNET.Month.December)
		{
			return (Month)Integer((int)min, (int)max + 1);
		}

		/// <summary>
		/// Return a random timezone.
		/// <para>Picks only from the timezones that are found on the system via TimeZoneInfo.GetSystemTimeZones()</para>
		/// </summary>
		/// <returns></returns>
		public TimeZoneInfo TimeZone()
		{
			ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();
			return PickOne(timeZones);
		}

		/// <summary>
		/// Return a weekday
		/// </summary>
		/// <returns></returns>
		public Weekday Weekday(WeekdayTypes type = WeekdayTypes.Any)
		{
			int min = type.HasFlag(WeekdayTypes.Weekday) ? 1 : 6;
			int max = type.HasFlag(WeekdayTypes.Weekend) ? 8 : 6;
			return (Weekday)Integer(min, max);
		}

		/// <summary>
		/// Generate a random year between min and max (inclusive).
		/// <para>By default, min is the current year and max is 100 years greater than min, with a ceiling on 9999, which is the maximum year for a DateTime field.</para>
		/// </summary>
		/// <returns></returns>
		public int Year(int? min, int? max)
		{
			int mn = min ?? DateTime.Now.Year;
			int mx = max ?? Math.Min(mn + 100, 9999);
			return Integer(mn, mx + 1);
		}

		/// <summary>
		/// Generate a random valid credit card number without spacing.
		/// </summary>
		/// <returns>The card number.</returns>
		/// <param name="types">Types.</param>
		public string CreditCardNumber(CreditCardTypes? types = null)
		{
			CreditCardType type = CreditCardType(types);

			StringBuilder number = new StringBuilder();

			// Start with the prefix
			number.Append(type.Prefix);

			// Generate every digit except the last
			while (number.Length < type.Length - 1)
			{
				number.Append(Natural(max: 10));
			}

			// Generate the last digit according to Luhn algorithm
			int[] digits = number.ToString().ToCharArray().Select(digit => (int)(digit - '0')).ToArray();
			number.Append(LuhnCalculate(digits));

			return number.ToString();
		}

		static int LuhnCalculate(int[] digits)
		{
			digits = digits.Reverse().ToArray();
			int sum = 0;

			for (int i = 0, l = digits.Length; l > i; ++i)
			{
				int digit = +digits[i];
				if (i % 2 == 0)
				{
					digit *= 2;
					if (digit > 9)
					{
						digit -= 9;
					}
				}
				sum += digit;
			}
			return (sum * 9) % 10;

		}

		public CreditCardType CreditCardType(CreditCardTypes? types = null)
		{
			CreditCardTypes type = types ?? (CreditCardTypes)0xFF;

			IEnumerable<CreditCardType> pool = Data.CreditCardTypes.Where(t => type.HasFlag(t.Type));

			return PickOne(pool);
		}

		/// <summary>
		/// Generate a random credit card expiration year.
		/// <para>A random year between today and 10 years in the future.</para>
		/// </summary>
		/// <returns></returns>
		public int ExpirationYear()
		{
			int min = (DateTime.Now.Month + 1 == 12) ? DateTime.Now.Year + 1 : DateTime.Now.Year;
			int max = DateTime.Now.Year + 10;
			return Year(min, max);
		}

		/// <summary>
		/// Generate a random credit card expiration month.
		/// <para>If expYear is set and is the current year then this will make sure that the expiration month is after the current month.</para>
		/// <para>This because many credit card sandboxes require an expiration date later than the current date so it’s necessary when generating
		/// an expiration with the current year to generate a month later than the current month.</para>
		/// <para>Exception to the above would be if the current month is December.</para>
		/// </summary>
		/// <param name="expYear">The expiration year of the card.</param>
		/// <returns></returns>
		public Month ExpirationMonth(int? expYear = null)
		{
			int min = (expYear != null && expYear == DateTime.Now.Year) ? DateTime.Now.Month + 1 : 1;
			if (min == 13)
				min = 12;
			return Month(min: (Month)min);
		}

		/// <summary>
		/// Generate a random credit card expiration date.
		/// <para>This DateTime object will point to the last day of the month, since that is when all credit card types expire.
		/// Thus making the returned object useful for comparisons.</para>
		/// </summary>
		/// <returns></returns>
		public DateTime ExpirationDate()
		{
			int year = ExpirationYear();
			int month = (int)ExpirationMonth(year);
			int day = DateTime.DaysInMonth(year, month);

			return new DateTime(year, month, day);
		}

		/// <summary>
		/// Generate a random credit card expiration in the MM/YYYY format.
		/// </summary>
		/// <returns></returns>
		public string ExpirationString()
		{
			int year = ExpirationYear();
			return Pad((int)ExpirationMonth(year), 2) + "/" + year;
		}

		/// <summary>
		/// Generate a random credit card that has not expired.
		/// </summary>
		/// <returns>The card.</returns>
		/// <param name="types">Types.</param>
		public CreditCard CreditCard(CreditCardTypes? types = null)
		{
			return new CreditCard(this, types);
		}

		/// <summary>
		/// Retrurns a random currency.
		/// </summary>
		/// <returns></returns>
		public Currency Currency()
		{
			return PickOne(Data.Currencies);
		}

		/// <summary>
		/// Generate a currency pair. Handy for simulating currency conversions. Guaranteed to return a unique pair (and not the same currency twice).
		/// </summary>
		/// <returns></returns>
		public Currency[] CurrencyPair()
		{
			Currency c1 = Currency();
			Currency c2;
			do
			{
				c2 = Currency();
			}
			while (c1.Code == c2.Code);
			return new Currency[2] { c1, c2 };
		}

		/// <summary>
		/// Return a random dollar amount, formatted with separators.
		/// <para>By default returns dollar amount lesser than 10000. Optionally specify the max to make it larger (or smaller).</para>
		/// </summary>
		/// <returns></returns>
		public string Dollar(double min = 0, double max = 10000)
		{
			double amount = Math.Round(Double(min, max), 2);

			string prefix = amount > 0 ? "$" : "-$";

			return string.Format("{0}{1:N2}", prefix, Math.Abs(amount));
		}

		/// <summary>
		/// Return a random euro amount, formatted with separators.
		/// <para>By default returns dollar amount lesser than 10000. Optionally specify the max to make it larger (or smaller).</para>
		/// </summary>
		/// <returns></returns>
		public string Euro(double min = 0, double max = 10000)
		{
			double amount = Math.Round(Double(min, max), 2);

			return string.Format("{0:N2}€", amount);
		}

		/// <summary>
		/// Flips a coin
		/// </summary>
		/// <returns>The coin.</returns>
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
			StringBuilder num = new StringBuilder();
			num.Append(number);

			while (num.Length < length)
			{
				num.Insert(0, padder);
			}

			return num.ToString();
		}

		public static string Capitalize(string text)
		{
			char[] chars = text.ToCharArray();
			chars[0] = char.ToUpper(chars[0]);
			return new string(chars);
		}

		/// <summary>
		/// Given two sets of geographical coordinates, calculate their distance in meters.
		/// </summary>
		/// <param name="lat1"></param>
		/// <param name="lng1"></param>
		/// <param name="lat2"></param>
		/// <param name="lng2"></param>
		/// <returns></returns>
		public static double Distance(double lat1, double lng1, double lat2, double lng2)
		{
			const int EARTH_RADIUS = 6371000;

			Func<double, double> toRad = ang =>
			{
				return (Math.PI / 180) * ang;
			};

			double dLng = toRad(lng1 - lng2);
			double dLat = toRad(lat1 - lat2);
			double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
					+ Math.Cos(toRad(lat1)) * Math.Cos(toRad(lat2))
					* Math.Sin(dLng / 2) * Math.Sin(dLng / 2);
			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
			return (float)(EARTH_RADIUS * c);
		}

		public int Dice(int sides)
		{
			return Integer(1, sides + 1);
		}

		public int D4()
		{
			return Dice(4);
		}

		public int D6()
		{
			return Dice(6);
		}

		public int D8()
		{
			return Dice(8);
		}

		public int D10()
		{
			return Dice(10);
		}

		public int D12()
		{
			return Dice(12);
		}

		public int D20()
		{
			return Dice(20);
		}

		public int D30()
		{
			return Dice(30);
		}

		public int D100()
		{
			return Dice(100);
		}

		/// <summary>
		/// Given an input looking like #d#, where the first # is the number of dice to roll and the second # is the max of each die, returns an array of dice values.
		/// </summary>
		/// <param name="rolls"></param>
		/// <returns></returns>
		public int[] Rpg(string rolls)
		{
			int times = int.Parse(rolls.Split('d')[0]);
			int dice = int.Parse(rolls.Split('d')[1]);

			int[] results = new int[times];
			for (int i = 0; i < times; i++)
			{
				results[i] = Dice(dice);
			}
			return results;
		}

		/// <summary>
		/// Given an input looking like #d#, where the first # is the number of dice to roll and the second # is the max of each die, returns the sum of the dice rolled.
		/// </summary>
		/// <param name="rolls"></param>
		/// <returns></returns>
		public int RpgSum(string rolls)
		{
			return Rpg(rolls).Sum();
		}

		/// <summary>
		/// Generate a random radio call sign.
		/// </summary>
		/// <param name="side"></param>
		/// <returns></returns>
		public string Radio(RadioSide? side = null)
		{
			StringBuilder radio = new StringBuilder();
			switch (side)
			{
				case RadioSide.East:
					radio.Append('W');
					break;

				case RadioSide.West:
					radio.Append('K');
					break;

				default:
					radio.Append(Char("KW"));
					break;
			}

			radio.Append(char.ToUpper(Alphanumeric()));
			radio.Append(char.ToUpper(Alphanumeric()));
			radio.Append(char.ToUpper(Alphanumeric()));

			return radio.ToString();
		}

		/// <summary>
		/// Generate a TV station call sign. This is an alias for Radio() since they both follow the same rules.
		/// </summary>
		/// <param name="side"></param>
		/// <returns></returns>
		public string Tv(RadioSide? side = null)
		{
			return Radio(side);
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
		/// Get a random file extension.
		/// </summary>
		/// <returns>The extension.</returns>
		/// <param name="type">Type.</param>
		public string FileExtension(FileExtensionTypes? type = null)
		{
			if (type == null)
			{
				return PickOne(Data.FileExtensions.Any);
			}

			List<string> extensions = new List<string>();

			FileExtensionTypes t = (FileExtensionTypes)type;

			if (t.HasFlag(FileExtensionTypes.Raster))
			{
				extensions.AddRange(Data.FileExtensions.Raster);
			}
			if (t.HasFlag(FileExtensionTypes.Vector))
			{
				extensions.AddRange(Data.FileExtensions.Vector);
			}
			if (t.HasFlag(FileExtensionTypes._3D))
			{
				extensions.AddRange(Data.FileExtensions._3D);
			}
			if (t.HasFlag(FileExtensionTypes.Document))
			{
				extensions.AddRange(Data.FileExtensions.Document);
			}

			return PickOne(extensions);
		}

		/// <summary>
		/// Provide any function that generates random stuff (usually another Chance function) and a number
		/// and Unique() will generate a random array of unique (not repeating) items with a length matching the one you specified.
		/// </summary>
		/// <returns>The unique.</returns>
		/// <param name="length">Length.</param>
		/// <param name="func">Func.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public List<T> Unique<T>(int length, Func<T> func)
		{
			List<T> list = new List<T>();
			for (int i = 0; i < length; i++)
			{
				T val;
				do
				{
					val = func();
				} 
				while (list.Contains(val));
					
				list.Add(val);
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

		/// <summary>
		/// Picks a number of random unique elements from the given list.
		/// </summary>
		/// <returns>The set.</returns>
		/// <param name="list">List.</param>
		/// <param name="count">Count.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public IEnumerable<T> PickSet<T>(IEnumerable<T> list, int count = 1)
		{
			return Shuffle(list).Take(count);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="weight">Given an item, this function should return its weight.</param>
		/// <returns></returns>
		public T Weighted<T>(IEnumerable<T> list, Func<T, double> weight)
		{
			Dictionary<T, double> weightedList = list.ToDictionary(
				t => t,
				t => weight(t)
				);

			return Weighted(weightedList);
		}

		/// <summary>
		/// Given a dictionary where each key-value pair is an item and its weight, this method made a weighted random pick of one item and return it.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="weightedList"></param>
		/// <returns></returns>
		public T Weighted<T>(Dictionary<T, double> weightedList)
		{
			double sum = weightedList.Sum(t => t.Value);
			double selected = sum * Double();

			double partSum = 0;
			foreach (T item in weightedList.Keys)
			{
				if (weightedList[item] < 0)
				{
					throw new ArgumentOutOfRangeException("Weights cannot be negative.");
				}

				partSum += weightedList[item];

				if (partSum > selected)
				{
					return item;
				}
			}
			throw new ArgumentException("List was empty");
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

		/// <summary>
		/// This instance will use its own random generator to produce the seed for a new Chance instance and return it.
		/// </summary>
		/// <returns></returns>
		public Chance New()
		{
			return new Chance(Integer());
		}
	}
}

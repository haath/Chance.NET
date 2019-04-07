using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChanceNET;
using ChanceNET.Attributes;

namespace ChanceNET.Tests
{
	public class Book
	{
		[Year]
		public int Year;

		[Sentence]
		public string Title;

		[Date]
		public DateTime Release;
		
		[Person(emailDomain: "gmail.com")]
		public Person Author;

		[Location]
		public Location Location;

		[Guid]
		public string Guid;

		[Double(0, 100)]
		public double Price;

		[Color]
		public string CoverColor;

		[Url]
		public string Website;

		[Enum(typeof(Genre))]
		public Genre Genre;

		[Object(typeof(Publisher))]
		public Publisher Publisher;
	}

	public enum Genre
	{
		Murder = 1,
		Mystery = 2,
		Comedy = 3,
		Erotica = 4,
		Biography = 5
	}
}

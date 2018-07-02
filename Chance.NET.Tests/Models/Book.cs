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
		
		[Person]
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
	}
}

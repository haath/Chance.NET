using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}

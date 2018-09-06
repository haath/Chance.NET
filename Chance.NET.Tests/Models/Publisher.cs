using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChanceNET.Attributes;

namespace ChanceNET.Tests
{
	public class Publisher
	{
		[Age(AgeRanges.Teen)]
		public int Age;

		[FullName]
		public string Name;

		[Date]
		public DateTime Birthday;
	}
}

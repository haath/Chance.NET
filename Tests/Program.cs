using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChanceNET;

namespace Tests
{
	class Program
	{
		const int COUNT = 10000;

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Chance c = new Chance();

			double min = double.MaxValue;
			double max = double.MinValue;

			Location l0 = c.Location();

			for (int i = 0; i < COUNT; i++)
			{
				Location lx = c.Location(l0.Latitude, l0.Longitude, 100);
				Console.WriteLine(lx.ToString() + " " + Chance.Distance(l0, lx));
			}
			
		}

		[Flags]
		enum Test
		{
			Val1	= 1,
			val2	= 2,
			Val3	= 4
		}
	}
}

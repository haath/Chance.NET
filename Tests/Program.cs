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
				Location l1 = c.Location(l0, 1000);

				double d = Chance.Distance(l0, l1);

				min = Math.Min(min, d);
				max = Math.Max(max, d);

				Console.WriteLine(l1.ToString() + "\t" + d);
			}

			Console.WriteLine("Min: " + min);
			Console.WriteLine("Max: " + max);
			
		}
	}
}

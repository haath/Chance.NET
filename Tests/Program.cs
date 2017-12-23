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
				Console.WriteLine(c.PickEnum<Test>());
			}
			
		}

		enum Test
		{
			Val1,
			val2,
			Val3
		}
	}
}

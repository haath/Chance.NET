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
				Test t = c.PickFlags<Test>(6);
				Console.WriteLine(t + " " + t.HasFlag(Test.Val1) + " " + t.HasFlag(Test.val2) + " " + t.HasFlag(Test.Val3));
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

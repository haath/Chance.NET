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
		static void Main(string[] args)
		{
			Chance c = new Chance();

			int[] count = new int[11];

			for (int i = 0; i < 1000; i++)
			{
				int[] test = new int[11] {
					0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
				};

				int p = c.Weighted(test, t => t);
				count[p]++;
			}

			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine(i + " " + count[i]);
			}
		}
	}
}

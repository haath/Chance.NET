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
				Console.WriteLine(c.Profession(true));
			}
		}
	}
}

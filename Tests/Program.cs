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

			int count = 1000;

			foreach (string postal in c.N(count, () => c.Address()))
			{
				Console.WriteLine(postal);
			}
		}
	}
}

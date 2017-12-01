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

			int count = 100000;
			double sum = 0;

			for (int i = 0; i < count; i++)
			{
				double s = c.Normal();
				sum += s;
				Console.WriteLine(s);
			}
			Console.WriteLine(sum / count);
		}
	}
}

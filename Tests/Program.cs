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
			

			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(c.Guid());
			}
		}
	}
}

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
		const int COUNT = 1000;

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Chance c = new Chance();

			for (int i = 0; i < COUNT; i++)
			{
				Console.WriteLine(c.IP("192.168.1.0/24"));
			}
		}
	}
}

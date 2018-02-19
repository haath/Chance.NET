using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChanceNET;
using ChanceNET.Attributes;

namespace Tests
{
	public class Obj
	{
		[Integer(10, 30)]
		public int FirstName;
	}

	class Program
	{
		const int COUNT = 10000;

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Chance c = new Chance();

			Location l0 = c.Location();

			for (int i = 0; i < COUNT; i++)
			{
				Obj o = c.Object<Obj>();
				Console.WriteLine(o.FirstName);
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

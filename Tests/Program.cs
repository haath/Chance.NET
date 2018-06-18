using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChanceNET;
using ChanceNET.Attributes;

using Newtonsoft.Json;

namespace Tests
{
	public class Book
	{
		[Year]
		public int PublishingYear;

		[String(10)]
		public string Title;
		
		[Paragraph(sentences: 10)]
		public string Summary;
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
				Book o = c.Object<Book>();


				Console.WriteLine(o.Summary);
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

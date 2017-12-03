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
			Chance c = new Chance();

			for (int i = 0; i < COUNT; i++)
			{
				CreditCard card = c.CreditCard();

				Console.WriteLine(card.Type + "\t\t" + card.FormattedNumber);
			}
		}
	}
}

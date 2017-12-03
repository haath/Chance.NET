using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct CreditCard
	{
		public readonly CreditCardType TypeInfo;
		public readonly string Number;
		public readonly DateTime ExpirationDate;

		public CreditCardTypes Type
		{
			get { return TypeInfo.Type; }
		}

		public int ExpirationYear
		{
			get { return ExpirationDate.Year; }
		}

		public Month ExpirationMonth
		{
			get { return (Month)ExpirationDate.Month; }
		}

		public string ExpirationString
		{
			get { return Chance.Pad((int)ExpirationMonth, 2) + "/" + ExpirationYear; }
		}

		public string FormattedNumber
		{
			get
			{
				StringBuilder number = new StringBuilder();
				int[] pattern = TypeInfo.SpacingPattern.Split('-').Select(p => int.Parse(p)).ToArray();
				int index = 0;
				for (int i = 0; i < pattern.Length; i++)
				{
					if (i > 0)
						number.Append(' ');

					for (int k = 0; k < pattern[i]; k++)
						number.Append(Number[index++]);
				}
				return number.ToString();
			}
		}

		internal CreditCard(Chance chance, CreditCardTypes? types = null)
		{
			TypeInfo = chance.CreditCardType(types);
			Number = chance.CreditCardNumber(TypeInfo.Type);
			ExpirationDate = chance.ExpirationDate();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct CreditCardType
	{
		public readonly CreditCardTypes Type;
		public readonly string Name;
		public readonly string ShortName;
		public readonly string Prefix;
		public readonly int Length;
		public readonly string SpacingPattern;

		internal CreditCardType(CreditCardTypes type, string name, string shortName, string prefix, int length, string spacing)
		{
			Type = type;
			Name = name;
			ShortName = shortName;
			Prefix = prefix;
			Length = length;
			SpacingPattern = spacing;
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class CreditCardNumberAttribute : ChanceAttribute
	{
		CreditCardTypes types;


		public CreditCardNumberAttribute(CreditCardTypes types = (CreditCardTypes)0xFF)
		{
			this.types = types;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.CreditCardNumber(types);
		}
	}
}

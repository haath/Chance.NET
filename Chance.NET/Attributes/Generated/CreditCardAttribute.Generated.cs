using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class CreditCardAttribute : ChanceAttribute
	{
		CreditCardTypes? types;


		public CreditCardAttribute(CreditCardTypes? types = null)
		{
			this.types = types;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.CreditCard(types);
		}
	}
}

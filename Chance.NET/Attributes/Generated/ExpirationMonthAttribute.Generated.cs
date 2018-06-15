using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ExpirationMonthAttribute : ChanceAttribute
	{
		Int32 expYear = 0;


		public ExpirationMonthAttribute(Int32 expYear = 0)
		{
			this.expYear = expYear;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.ExpirationMonth(expYear);
		}
	}
}

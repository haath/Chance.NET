using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class MonthAttribute : ChanceAttribute
	{
		Month min;
		Month max;


		public MonthAttribute(Month min = (Month)0xFF, Month max = (Month)0xFF)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Month(min, max);
		}
	}
}

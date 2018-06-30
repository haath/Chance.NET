using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class WeekdayAttribute : ChanceAttribute
	{
		WeekdayTypes type = (WeekdayTypes)~0;


		public WeekdayAttribute(WeekdayTypes type = (WeekdayTypes)~0)
		{
			this.type = type;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Weekday(type);
		}
	}
}

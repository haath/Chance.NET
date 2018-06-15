using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class YearAttribute : ChanceAttribute
	{
		Int32 min = 0;
		Int32 max = 9999;


		public YearAttribute(Int32 min = 0, Int32 max = 9999)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Year(min, max);
		}
	}
}

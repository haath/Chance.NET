using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class LongAttribute : ChanceAttribute
	{
		Int64 min;
		Int64 max;


		public LongAttribute(Int64 min = -9223372036854775808, Int64 max = 9223372036854775807)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Long(min, max);
		}
	}
}

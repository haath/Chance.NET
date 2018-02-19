using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class DoubleAttribute : ChanceAttribute
	{
		Double min;
		Double max;


		public DoubleAttribute(Double min = 0, Double max = 1)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Double(min, max);
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class DollarAttribute : ChanceAttribute
	{
		Double min;
		Double max;


		public DollarAttribute(Double min = 0, Double max = 10000)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Dollar(min, max);
		}
	}
}

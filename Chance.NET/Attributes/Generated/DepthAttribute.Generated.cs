using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class DepthAttribute : ChanceAttribute
	{
		Double min = -10994;
		Double max = 0;


		public DepthAttribute(Double min = -10994, Double max = 0)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Depth(min, max);
		}
	}
}

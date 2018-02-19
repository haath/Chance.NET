using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class NormalAttribute : ChanceAttribute
	{
		Double min;
		Double max;


		public NormalAttribute(Double min, Double max)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Normal(min, max);
		}
	}
}

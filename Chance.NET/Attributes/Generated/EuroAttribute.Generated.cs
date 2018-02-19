using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class EuroAttribute : ChanceAttribute
	{
		Double min = 0;
		Double max = 10000;


		public EuroAttribute(Double min = 0, Double max = 10000)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Euro(min, max);
		}
	}
}

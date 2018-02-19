using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class LatitudeAttribute : ChanceAttribute
	{
		Double min = -90;
		Double max = 90;


		public LatitudeAttribute(Double min = -90, Double max = 90)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Latitude(min, max);
		}
	}
}

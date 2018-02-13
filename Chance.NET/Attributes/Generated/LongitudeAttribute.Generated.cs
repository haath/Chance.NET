using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class LongitudeAttribute : ChanceAttribute
	{
		Double min;
		Double max;


		public LongitudeAttribute(Double min = -180, Double max = 180)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Longitude(min, max);
		}
	}
}

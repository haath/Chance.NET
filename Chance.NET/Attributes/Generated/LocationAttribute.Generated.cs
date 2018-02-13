using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class LocationAttribute : ChanceAttribute
	{
		Location center;
		Double range;


		public LocationAttribute(Location center, Double range)
		{
			this.center = center;
			this.range = range;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Location(center, range);
		}
	}
}

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
		Double minLat;
		Double maxLat;
		Double minLng;
		Double maxLng;


		public LocationAttribute(Double minLat = -90, Double maxLat = 90, Double minLng = -180, Double maxLng = 180)
		{
			this.minLat = minLat;
			this.maxLat = maxLat;
			this.minLng = minLng;
			this.maxLng = maxLng;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Location(minLat, maxLat, minLng, maxLng);
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class CoordinatesAttribute : ChanceAttribute
	{
		Double latMin = -90;
		Double latMax = 90;
		Double lngMin = -180;
		Double lngMax = 180;


		public CoordinatesAttribute(Double latMin = -90, Double latMax = 90, Double lngMin = -180, Double lngMax = 180)
		{
			this.latMin = latMin;
			this.latMax = latMax;
			this.lngMin = lngMin;
			this.lngMax = lngMax;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Coordinates(latMin, latMax, lngMin, lngMax);
		}
	}
}

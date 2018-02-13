using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class GeohashAttribute : ChanceAttribute
	{
		Int32 length;


		public GeohashAttribute(Int32 length = 7)
		{
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Geohash(length);
		}
	}
}

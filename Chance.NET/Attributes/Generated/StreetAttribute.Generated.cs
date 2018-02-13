using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class StreetAttribute : ChanceAttribute
	{
		Boolean shortSuffix;


		public StreetAttribute(Boolean shortSuffix = true)
		{
			this.shortSuffix = shortSuffix;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Street(shortSuffix);
		}
	}
}

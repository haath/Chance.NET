using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class AgeAttribute : ChanceAttribute
	{
		AgeRanges range;


		public AgeAttribute(AgeRanges range = AgeRanges.Any)
		{
			this.range = range;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Age(range);
		}
	}
}

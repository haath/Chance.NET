using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class BirthdayAttribute : ChanceAttribute
	{
		AgeRanges range = (AgeRanges)~0;


		public BirthdayAttribute(AgeRanges range = (AgeRanges)~0)
		{
			this.range = range;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Birthday(range);
		}
	}
}

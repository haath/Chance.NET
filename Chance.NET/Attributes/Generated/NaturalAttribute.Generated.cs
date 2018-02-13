using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class NaturalAttribute : ChanceAttribute
	{
		Int32 max;


		public NaturalAttribute(Int32 max = 2147483647)
		{
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Natural(max);
		}
	}
}

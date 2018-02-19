using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class IntegerAttribute : ChanceAttribute
	{
		Int32 min = -2147483648;
		Int32 max = 2147483647;


		public IntegerAttribute(Int32 min = -2147483648, Int32 max = 2147483647)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Integer(min, max);
		}
	}
}

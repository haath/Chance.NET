using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class NormalIntegerAttribute : ChanceAttribute
	{
		Int32 min;
		Int32 max;


		public NormalIntegerAttribute(Int32 min, Int32 max)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.NormalInteger(min, max);
		}
	}
}

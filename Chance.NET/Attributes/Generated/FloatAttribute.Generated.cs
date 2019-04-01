using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class FloatAttribute : ChanceAttribute
	{
		Single min = 0;
		Single max = 1;


		public FloatAttribute(Single min = 0, Single max = 1)
		{
			this.min = min;
			this.max = max;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Float(min, max);
		}
	}
}

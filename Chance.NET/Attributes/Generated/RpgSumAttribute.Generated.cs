using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class RpgSumAttribute : ChanceAttribute
	{
		String rolls;


		public RpgSumAttribute(String rolls)
		{
			this.rolls = rolls;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.RpgSum(rolls);
		}
	}
}

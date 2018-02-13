using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class RpgAttribute : ChanceAttribute
	{
		String rolls;


		public RpgAttribute(String rolls)
		{
			this.rolls = rolls;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Rpg(rolls);
		}
	}
}

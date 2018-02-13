using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class DiceAttribute : ChanceAttribute
	{
		Int32 sides;


		public DiceAttribute(Int32 sides)
		{
			this.sides = sides;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Dice(sides);
		}
	}
}

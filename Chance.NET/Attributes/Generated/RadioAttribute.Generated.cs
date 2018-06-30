using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class RadioAttribute : ChanceAttribute
	{
		RadioSide side = (RadioSide)~0;


		public RadioAttribute(RadioSide side = (RadioSide)~0)
		{
			this.side = side;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Radio(side);
		}
	}
}

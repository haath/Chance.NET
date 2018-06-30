using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class TvAttribute : ChanceAttribute
	{
		RadioSide side = (RadioSide)~0;


		public TvAttribute(RadioSide side = (RadioSide)~0)
		{
			this.side = side;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Tv(side);
		}
	}
}

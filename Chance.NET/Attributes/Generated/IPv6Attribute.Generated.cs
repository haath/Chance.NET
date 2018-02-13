using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class IPv6Attribute : ChanceAttribute
	{


		public IPv6Attribute()
		{

		}

		internal override object GetValue(Chance chance)
		{
			return chance.IPv6();
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class D6Attribute : ChanceAttribute
	{


		public D6Attribute()
		{

		}

		internal override object GetValue(Chance chance)
		{
			return chance.D6();
		}
	}
}

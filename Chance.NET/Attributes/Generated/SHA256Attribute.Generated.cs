using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class SHA256Attribute : ChanceAttribute
	{


		public SHA256Attribute()
		{

		}

		internal override object GetValue(Chance chance)
		{
			return chance.SHA256();
		}
	}
}

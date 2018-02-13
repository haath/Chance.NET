using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class SHA512Attribute : ChanceAttribute
	{


		public SHA512Attribute()
		{

		}

		internal override object GetValue(Chance chance)
		{
			return chance.SHA512();
		}
	}
}

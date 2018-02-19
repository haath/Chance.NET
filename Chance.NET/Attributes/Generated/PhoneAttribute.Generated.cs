using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class PhoneAttribute : ChanceAttribute
	{
		String areaCode = null;
		Boolean formatted = true;


		public PhoneAttribute(String areaCode = "null", Boolean formatted = true)
		{
			this.areaCode = areaCode;
			this.formatted = formatted;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Phone(areaCode, formatted);
		}
	}
}

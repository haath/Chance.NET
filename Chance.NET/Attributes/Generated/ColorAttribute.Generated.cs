using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ColorAttribute : ChanceAttribute
	{
		Byte? red;
		Byte? green;
		Byte? blue;


		public ColorAttribute(Byte? red = null, Byte? green = null, Byte? blue = null)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Color(red, green, blue);
		}
	}
}

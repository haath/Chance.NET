using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class HexAttribute : ChanceAttribute
	{
		Int32 length;


		public HexAttribute(Int32 length)
		{
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Hex(length);
		}
	}
}

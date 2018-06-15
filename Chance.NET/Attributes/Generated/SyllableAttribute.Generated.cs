using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class SyllableAttribute : ChanceAttribute
	{
		Int32 length = 0;


		public SyllableAttribute(Int32 length = 0)
		{
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Syllable(length);
		}
	}
}

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
		Int32? length = null;


		public SyllableAttribute(Int32? length = null)
		{
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Syllable(length);
		}
	}
}

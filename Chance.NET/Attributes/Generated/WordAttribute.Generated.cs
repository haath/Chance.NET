using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class WordAttribute : ChanceAttribute
	{
		Int32 syllables = 0;
		Int32 length = 0;
		Boolean capitalize = false;


		public WordAttribute(Int32 syllables = 0, Int32 length = 0, Boolean capitalize = false)
		{
			this.syllables = syllables;
			this.length = length;
			this.capitalize = capitalize;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Word(syllables, length, capitalize);
		}
	}
}

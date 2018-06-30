using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class FullNameAttribute : ChanceAttribute
	{
		Gender gender = (Gender)~0;
		Boolean prefix = false;
		Boolean middle = false;
		Boolean middleInitial = false;
		Boolean suffix = false;


		public FullNameAttribute(Gender gender = (Gender)~0, Boolean prefix = false, Boolean middle = false, Boolean middleInitial = false, Boolean suffix = false)
		{
			this.gender = gender;
			this.prefix = prefix;
			this.middle = middle;
			this.middleInitial = middleInitial;
			this.suffix = suffix;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FullName(gender, prefix, middle, middleInitial, suffix);
		}
	}
}

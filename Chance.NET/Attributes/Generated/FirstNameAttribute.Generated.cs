using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class FirstNameAttribute : ChanceAttribute
	{
		Gender gender = (Gender)~0;


		public FirstNameAttribute(Gender gender = (Gender)~0)
		{
			this.gender = gender;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FirstName(gender);
		}
	}
}

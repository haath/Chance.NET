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
		Gender? gender;


		public FirstNameAttribute(Gender? gender = null)
		{
			this.gender = gender;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FirstName(gender);
		}
	}
}

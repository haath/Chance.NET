using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ProfessionAttribute : ChanceAttribute
	{
		Boolean rank;


		public ProfessionAttribute(Boolean rank = false)
		{
			this.rank = rank;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Profession(rank);
		}
	}
}

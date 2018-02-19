using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class SSNAttribute : ChanceAttribute
	{
		Boolean dashes = true;
		Boolean ssnFour = false;


		public SSNAttribute(Boolean dashes = true, Boolean ssnFour = false)
		{
			this.dashes = dashes;
			this.ssnFour = ssnFour;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.SSN(dashes, ssnFour);
		}
	}
}

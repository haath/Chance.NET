using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class EmailAttribute : ChanceAttribute
	{
		Int32? length;
		String domain;
		String tld;


		public EmailAttribute(Int32? length = null, String domain = "null", String tld = "null")
		{
			this.length = length;
			this.domain = domain;
			this.tld = tld;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Email(length, domain, tld);
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class UrlAttribute : ChanceAttribute
	{
		String scheme = null;
		String domain = null;
		String path = null;
		String extension = null;


		public UrlAttribute(String scheme = "null", String domain = "null", String path = "null", String extension = "null")
		{
			this.scheme = scheme;
			this.domain = domain;
			this.path = path;
			this.extension = extension;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Url(scheme, domain, path, extension);
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class EndPointAttribute : ChanceAttribute
	{
		String subnet = null;
		UInt16 port = 0;


		public EndPointAttribute(String subnet = null, UInt16 port = 0)
		{
			this.subnet = subnet;
			this.port = port;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.EndPoint(subnet, port);
		}
	}
}

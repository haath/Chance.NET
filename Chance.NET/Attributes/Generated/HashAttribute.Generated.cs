using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class HashAttribute : ChanceAttribute
	{
		Int32 length;


		public HashAttribute(Int32 length)
		{
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Hash(length);
		}
	}
}

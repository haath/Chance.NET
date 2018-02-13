using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public abstract class ChanceAttribute : Attribute
	{
		internal abstract object GetValue(Chance chance);
	}
}

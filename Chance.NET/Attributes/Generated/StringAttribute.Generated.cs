using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class StringAttribute : ChanceAttribute
	{
		Int32 length;
		String pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";


		public StringAttribute(Int32 length, String pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()")
		{
			this.length = length;
			this.pool = pool;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.String(length, pool);
		}
	}
}

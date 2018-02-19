using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class NullableDefaultAttribute : Attribute
	{
		public readonly string Name;
		public readonly string DefaultValue;

		internal NullableDefaultAttribute(string paramName, string defaultValue)
		{
			Name = paramName;
			DefaultValue = defaultValue;
		}
	}
}

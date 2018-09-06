using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ObjectAttribute : ChanceAttribute
	{
		Type objectType;

		public ObjectAttribute(Type objectType)
		{
			this.objectType = objectType;
		}

		internal override object GetValue(Chance chance)
		{
			MethodInfo method = chance.GetType()
									  .GetTypeInfo()
									  .GetMethod("Object", new Type[] { })
									  .MakeGenericMethod(objectType);
			return method.Invoke(chance, null);
		}
	}
}

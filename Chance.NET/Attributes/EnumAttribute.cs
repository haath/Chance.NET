using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class EnumAttribute : ChanceAttribute
	{
		Type enumType;

		public EnumAttribute(Type enumType)
		{
			this.enumType = enumType;
		}

		internal override object GetValue(Chance chance)
		{
			return Enum.ToObject(enumType, chance.PickEnum(enumType));
		}
	}
}

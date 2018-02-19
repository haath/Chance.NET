using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class AvatarAttribute : ChanceAttribute
	{
		GravatarDefaults defaultType = (GravatarDefaults)0xFF;


		public AvatarAttribute(GravatarDefaults defaultType = (GravatarDefaults)0xFF)
		{
			this.defaultType = defaultType;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Avatar(defaultType);
		}
	}
}

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class AddressAttribute : ChanceAttribute
	{
		Boolean numberFirst = true;
		Boolean shortStreetSuffix = true;
		Int32 minNumber = 5;
		Int32 maxNumber = 2000;


		public AddressAttribute(Boolean numberFirst = true, Boolean shortStreetSuffix = true, Int32 minNumber = 5, Int32 maxNumber = 2000)
		{
			this.numberFirst = numberFirst;
			this.shortStreetSuffix = shortStreetSuffix;
			this.minNumber = minNumber;
			this.maxNumber = maxNumber;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Address(numberFirst, shortStreetSuffix, minNumber, maxNumber);
		}
	}
}

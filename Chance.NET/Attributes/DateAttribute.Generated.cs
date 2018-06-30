using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class DateAttribute : ChanceAttribute
	{
		Int32 year = 0;
		Month month = (Month)0;
		Int32 day = 0;
		Int32 minYear = 1970;
		Int32 maxYear = 9999;


		public DateAttribute(Int32 year = 0, Month month = (Month)0, Int32 day = 0, Int32 minYear = 1970, Int32 maxYear = 9999)
		{
			this.year = year;
			this.month = month;
			this.day = day;
			this.minYear = minYear;
			this.maxYear = maxYear;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Date(year, month, day, minYear, maxYear);
		}
	}
}

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
		Int32? year;
		Month? month;
		Int32? day;
		Int32? minYear;
		Int32? maxYear;


		public DateAttribute(Int32? year = null, Month? month = null, Int32? day = null, Int32? minYear = null, Int32? maxYear = null)
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

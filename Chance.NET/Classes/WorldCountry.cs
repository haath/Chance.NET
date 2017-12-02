using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct WorldCountry
	{

		internal WorldCountry(string name, string alpha2Code, string alpha3Code, string numericCode, bool enabled)
		{
			Name = name;
			Alpha2Code = alpha2Code;
			Alpha3Code = alpha3Code;
			NumericCode = numericCode;
			Enabled = enabled;
		}

		public string Name { get; private set; }
		public string Alpha2Code { get; private set; }
		public string Alpha3Code { get; private set; }
		public string NumericCode { get; private set; }
		public bool Enabled { get; set; }

		public override string ToString()
		{
			//Returns "USA - United States"
			return string.Format("{0} - {1}", Alpha3Code, Name);
		}
	}
}

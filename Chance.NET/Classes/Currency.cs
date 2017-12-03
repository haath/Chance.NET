using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct Currency
	{
		public readonly string Code;
		public readonly string Name;
		public readonly string Symbol;
		public readonly string NamePlural;

		internal Currency(string code, string name, string symbol, string namePlural)
		{
			Code = code;
			Name = name;
			Symbol = symbol;
			NamePlural = namePlural;
		}
	}
}

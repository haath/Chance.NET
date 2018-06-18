using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class GenderAttribute : ChanceAttribute
	{
		Double maleLikelihood = 0.5;


		public GenderAttribute(Double maleLikelihood = 0.5)
		{
			this.maleLikelihood = maleLikelihood;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Gender(maleLikelihood);
		}
	}
}

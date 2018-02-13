using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class SentenceAttribute : ChanceAttribute
	{
		Int32? words;
		Int32? length;
		Boolean capitalize;
		Boolean punctuation;
		Char punctuationMark;


		public SentenceAttribute(Int32? words = null, Int32? length = null, Boolean capitalize = false, Boolean punctuation = false, Char punctuationMark = '.')
		{
			this.words = words;
			this.length = length;
			this.capitalize = capitalize;
			this.punctuation = punctuation;
			this.punctuationMark = punctuationMark;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Sentence(words, length, capitalize, punctuation, punctuationMark);
		}
	}
}

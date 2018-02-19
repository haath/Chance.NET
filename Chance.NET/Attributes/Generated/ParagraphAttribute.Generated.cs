using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ParagraphAttribute : ChanceAttribute
	{
		Int32? sentences = null;
		Int32? words = null;
		Int32? length = null;


		public ParagraphAttribute(Int32? sentences = null, Int32? words = null, Int32? length = null)
		{
			this.sentences = sentences;
			this.words = words;
			this.length = length;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Paragraph(sentences, words, length);
		}
	}
}

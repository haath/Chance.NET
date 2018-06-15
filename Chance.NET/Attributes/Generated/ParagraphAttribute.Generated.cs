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
		Int32 sentences = 0;
		Int32 words = 0;
		Int32 length = 0;


		public ParagraphAttribute(Int32 sentences = 0, Int32 words = 0, Int32 length = 0)
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

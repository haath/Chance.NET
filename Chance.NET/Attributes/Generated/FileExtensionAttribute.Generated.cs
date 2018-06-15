using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class FileExtensionAttribute : ChanceAttribute
	{
		FileExtensionTypes types = (FileExtensionTypes)0xFF;


		public FileExtensionAttribute(FileExtensionTypes types = (FileExtensionTypes)0xFF)
		{
			this.types = types;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FileExtension(types);
		}
	}
}

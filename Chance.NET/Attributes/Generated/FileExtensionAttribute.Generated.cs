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
		FileExtensionTypes type;


		public FileExtensionAttribute(FileExtensionTypes type = (FileExtensionTypes)0xFF)
		{
			this.type = type;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FileExtension(type);
		}
	}
}

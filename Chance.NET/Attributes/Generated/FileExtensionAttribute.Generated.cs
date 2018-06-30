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
		FileExtensionTypes types = (FileExtensionTypes)~0;


		public FileExtensionAttribute(FileExtensionTypes types = (FileExtensionTypes)~0)
		{
			this.types = types;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.FileExtension(types);
		}
	}
}

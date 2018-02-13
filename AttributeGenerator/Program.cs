using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using ChanceNET;
using ChanceNET.Attributes;

namespace AttributeGenerator.cs
{
	class Program
	{
		const string SAVE_PATH = "../../../Chance.NET/Attributes/Generated/";

		static void Main(string[] args)
		{
			MethodInfo[] methods = typeof(Chance).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
			string template = File.ReadAllText("AttributeTemplate.cs");

			Directory.CreateDirectory(SAVE_PATH);

			foreach (MethodInfo method in methods)
			{
				string generated = Generate(template, method);
				string fileName = string.Format("{0}Attribute.Generated.cs", method.Name);
				string filePath = Path.Combine(SAVE_PATH, fileName);

				if (generated != null)
				{
					File.WriteAllText(filePath, generated);
				}
			}
		}

		static string Generate(string template, MethodInfo method)
		{
			if (method.IsGenericMethod)
				return null;

			StringBuilder fields = new StringBuilder();
			StringBuilder parameters = new StringBuilder();
			StringBuilder fieldAssign = new StringBuilder();
			StringBuilder methodCallParams = new StringBuilder();

			ParameterInfo[] methodParams = method.GetParameters();
			foreach (ParameterInfo param in methodParams)
			{
				string paramTypeName = GetTypeName(param.ParameterType);
				Type paramType = GetParamType(param);

				if (!IsSimpleType(paramType))
					return null;

				fields.AppendFormat("		{0} {1};\n", paramTypeName, param.Name);
				fieldAssign.AppendFormat("			this.{0} = {0};\n", param.Name);

				if (parameters.Length > 0)
				{
					parameters.Append(", ");
					methodCallParams.Append(", ");
				}

				if (param.HasDefaultValue)
				{
					object defaultValue = param.DefaultValue ?? "null";
					if (paramType.IsEnum && !defaultValue.ToString().Equals("null"))
					{
						defaultValue = paramType.Name + "." + defaultValue;
					}
					if (paramType == typeof(string))
					{
						defaultValue = "\"" + defaultValue + "\"";
					}
					else if (paramType == typeof(char))
					{
						defaultValue = "'" + defaultValue + "'";
					}

					parameters.AppendFormat("{0} {1} = {2}", paramTypeName, param.Name, defaultValue);
				}
				else
				{
					parameters.AppendFormat("{0} {1}", paramTypeName, param.Name);
				}

				methodCallParams.Append(param.Name);
			}

			return template.Replace("@{name}", method.Name)
							.Replace("@{fields}", fields.ToString())
							.Replace("@{parameters}", parameters.ToString())
							.Replace("@{fieldAssign}", fieldAssign.ToString())
							.Replace("@{methodName}", method.Name)
							.Replace("@{methodCallParams}", methodCallParams.ToString())
							.Replace("True", "true")
							.Replace("False", "false");
		}

		static Type GetParamType(ParameterInfo param)
		{
			Type type = param.ParameterType;
			bool isNullable = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
			return isNullable ? type.GetGenericArguments()[0] : type;
		}

		static string GetTypeName(Type type)
		{
			bool isNullable = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
			Type paramType = isNullable ? type.GetGenericArguments()[0] : type;

			if (isNullable)
			{
				return paramType.Name + "?";
			}
			else if (type.IsGenericType)
			{
				string genericTypeName = type.GetGenericTypeDefinition().Name.Split('`')[0];
				StringBuilder genericArgs = new StringBuilder();

				foreach (Type genericArg in type.GetGenericArguments())
				{
					if (genericArgs.Length > 0)
						genericArgs.Append(", ");
					genericArgs.Append(GetTypeName(genericArg));
				}

				return string.Format("{0}<{1}>", genericTypeName, genericArgs.ToString());
			}
			else
			{
				return paramType.Name;
			}
		}

		static bool IsSimpleType(Type type)
		{
			return
				type.IsValueType ||
				type.IsPrimitive ||
				new Type[] {
				typeof(String),
				typeof(Decimal),
				typeof(DateTime),
				typeof(DateTimeOffset),
				typeof(TimeSpan),
				typeof(Guid)
				}.Contains(type) ||
				Convert.GetTypeCode(type) != TypeCode.Object;
		}
	}
}

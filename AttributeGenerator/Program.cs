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
		const BindingFlags BINDING_FLAGS = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
		const string SAVE_PATH = "../../../Chance.NET/Attributes/Generated/";
		

		static void Main(string[] args)
		{
			string template = File.ReadAllText("AttributeTemplate.cs");

			Directory.CreateDirectory(SAVE_PATH);

			foreach (string methodName in MethodNames())
			{
				List<MethodInfo> methods = MethodsWithName(methodName);
				string generated = Generate(template, methods);
				string fileName = string.Format("{0}Attribute.Generated.cs", methodName);
				string filePath = Path.Combine(SAVE_PATH, fileName);

				if (generated != null)
				{
					File.WriteAllText(filePath, generated);
				}
			}
		}

		static HashSet<string> MethodNames()
		{
			HashSet<string> methodNames = new HashSet<string>();
			MethodInfo[] methods = typeof(Chance).GetMethods(BINDING_FLAGS);
			foreach (MethodInfo method in methods)
			{
				methodNames.Add(method.Name);
			}
			return methodNames;
		}

		static List<MethodInfo> MethodsWithName(string name)
		{
			List<MethodInfo> methods = new List<MethodInfo>();
			foreach (MethodInfo method in typeof(Chance).GetMethods(BINDING_FLAGS))
			{
				if (method.Name == name)
					methods.Add(method);
			}
			return methods;
		}

		static List<ParameterInfo> JointParameters(List<MethodInfo> methods)
		{
			List<ParameterInfo> parameters = new List<ParameterInfo>();

			Func<ParameterInfo, bool> contains = (p) => parameters.Exists(param => param.Name == p.Name && param.ParameterType == p.ParameterType);
			Action<ParameterInfo> tryAdd = (p) =>
			{
				if (!contains(p) || p.HasDefaultValue)
				{
					parameters.RemoveAll(param => param.Name == p.Name && param.ParameterType == p.ParameterType);
					parameters.Add(p);
				}
			};

			foreach (MethodInfo method in methods)
			{
				foreach (ParameterInfo param in method.GetParameters())
				{
					tryAdd(param);
				}
			}

			return parameters;
		}

		static Type GetGeneric(List<MethodInfo> methods)
		{
			return methods.Exists(m => m.IsGenericMethod) ? methods.First(m => m.IsGenericMethod).GetGenericArguments()[0] : null;
		}

		static string Generate(string template, List<MethodInfo> methods)
		{
			if (GetGeneric(methods) != null)
				return null;

			StringBuilder fields = new StringBuilder();
			StringBuilder parameters = new StringBuilder();
			StringBuilder fieldAssign = new StringBuilder();
			StringBuilder methodCallParams = new StringBuilder();

			List<ParameterInfo> methodParams = JointParameters(methods);
			foreach (ParameterInfo param in methodParams)
			{
				string paramTypeName = GetTypeName(param.ParameterType);
				Type paramType = GetParamType(param);

				if (!IsSimpleType(paramType) || param.ParameterType == typeof(Location))
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
					else if (paramType.IsEnum)
					{
						defaultValue = string.Format("({0})0xFF", paramType.Name);
					}

					parameters.AppendFormat("{0} {1} = {2}", paramTypeName, param.Name, defaultValue);
				}
				else
				{
					parameters.AppendFormat("{0} {1}", paramTypeName, param.Name);
				}

				methodCallParams.Append(param.Name);
			}

			return template.Replace("@{name}", methods[0].Name)
							.Replace("@{fields}", fields.ToString())
							.Replace("@{parameters}", parameters.ToString())
							.Replace("@{fieldAssign}", fieldAssign.ToString())
							.Replace("@{methodName}", methods[0].Name)
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

			if (paramType.GetTypeInfo().IsEnum)
			{
				return paramType.Name;
			}
			else if (isNullable)
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

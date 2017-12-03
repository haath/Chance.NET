using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct Person
	{
		public readonly Gender Gender;
		public readonly string NamePrefix;
		public readonly string FirstName;
		public readonly string MiddleName;
		public readonly string LastName;
		public readonly string NameSuffix;
		public readonly string SSN;
		public readonly DateTime Birthday;
		public readonly string Phone;

		public int Age
		{
			get
			{
				int age = DateTime.Now.Year - Birthday.Year;
				if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
					age--;
				return age;
			}
		}

		public char MiddleInitial
		{
			get
			{
				return MiddleName[0];
			}
		}

		internal Person(Chance chance, AgeRanges ageRange = AgeRanges.Any, Gender? gender = null)
		{
			Gender = gender ?? chance.Gender();

			NamePrefix	= chance.NamePrefix(Gender);
			FirstName	= chance.FirstName(Gender);
			MiddleName	= chance.FirstName(Gender);
			LastName	= chance.LastName();
			NameSuffix	= chance.NameSuffix();
			SSN			= chance.SSN();
			Birthday	= chance.Birthday(ageRange);
			Phone		= chance.Phone();
		}

		public string FullName(bool prefix = false, bool middle = false, bool middleInitial = false, bool suffix = false)
		{
			StringBuilder name = new StringBuilder();

			if (prefix)
			{
				name.Append(NamePrefix);
				name.Append(' ');
			}

			name.Append(FirstName);
			name.Append(' ');

			if (middle && middleInitial)
			{
				name.Append(MiddleInitial);
				name.Append(". ");
			}
			else if (middle)
			{
				name.Append(MiddleName);
				name.Append(' ');
			}

			name.Append(LastName);

			if (suffix)
			{
				name.Append(' ');
				name.Append(NameSuffix);
			}

			return name.ToString();
		}
	}
}

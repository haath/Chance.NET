using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace ChanceNET.Tests
{
	/// <summary>
	/// Summary description for SerializationTests
	/// </summary>
	[TestFixture]
	public class SerializationTests
	{
		Chance chance = new Chance();

		[Test]
		public void Test1()
		{
			Book b = chance.Object<Book>();

			Assert.IsTrue(b.Year > 0);
			Assert.IsTrue(b.Release != default(DateTime));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Title));
		}

		[TearDown]
		public void Reset()
		{
			chance = chance.New();
		}
	}
}

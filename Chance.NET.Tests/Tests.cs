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
	public class Tests
	{
		const int TEST_LOOPS = 10000;

		Chance chance = new Chance();

		[Test]
		public void LocationTests()
		{
			for (int i = 0; i < TEST_LOOPS; i++)
			{
				Location loc = chance.Location();

				Assert.IsTrue(loc.Latitude != 0 && loc.Latitude >= -90 && loc.Latitude <= 90);
				Assert.IsTrue(loc.Longitude != 0 && loc.Longitude >= -180 && loc.Longitude <= 180);

				double distance = loc.DistanceTo(loc);

				Assert.AreEqual(0, distance);

				Location other = chance.Location(loc, 1000);
				Assert.IsTrue(loc.DistanceTo(other) < 1000);
			}
		}

		[Test]
		public void SerializationTests()
		{
			for (int i = 0; i < TEST_LOOPS; i++)
			{
				Book b = chance.Object<Book>();

				Assert.IsTrue(b.Year > 0);
				Assert.IsTrue(b.Price >= 0 && b.Price < 100);
				Assert.IsTrue(b.Release != default(DateTime));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Title));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Guid));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.CoverColor));
				Assert.IsTrue(b.CoverColor.StartsWith("#"));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.Email));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.FirstName));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.FullName()));
				Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.LastName));
				Assert.IsTrue(b.Location.Latitude != 0 && b.Location.Latitude >= -90 && b.Location.Latitude <= 90);
				Assert.IsTrue(b.Location.Longitude != 0 && b.Location.Longitude >= -180 && b.Location.Longitude <= 180);
				Assert.IsTrue(Uri.IsWellFormedUriString(b.Website, UriKind.Absolute));
			}
		}

		[Test]
		public void GenTests()
		{
			long prev;
			for (int i = 0; i < 1000; i++)
			{
				long cur = chance.Long();

				Assert.IsFalse(prev == cur);

				prev = cur;
			}
		}

		[TearDown]
		public void Reset()
		{
			chance = chance.New();
		}
	}
}

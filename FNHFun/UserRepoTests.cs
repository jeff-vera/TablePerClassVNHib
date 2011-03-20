using System;
using NUnit.Framework;

namespace FNHFun
{
	[TestFixture]
	public class UserRepoTests
	{
		[Test]
		public void CanSaveManagerTest()
		{
			Manager m = new Manager 
			{
				FirstName = "Bob",
				LastName = "Jones",
				Designation = "Awesome"
			};

			UserRepo.UpsertUser<Manager>(m);

			Assert.That(m.Id, Is.GreaterThan(0));
		}

		[Test]
		public void CanSaveCustomerTest()
		{
			Customer c = new Customer
			{
				FirstName = "Frank",
				LastName = "Smith",
				Level = "Gold"
			};

			UserRepo.UpsertUser<Customer>(c);

			Assert.That(c.Id, Is.GreaterThan(0));
		}
	}
}

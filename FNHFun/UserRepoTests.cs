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

			UserRepo.UpsertEntity<Manager>(m);

			Assert.That(m.Id, Is.GreaterThan(0));
		}

		[Test]
		public void CanAssignUserToRoleFromRoleTest()
		{
			Role r = new Role
			{
				Name = "RoleForFromRoleTest"
			};
			Manager m = UserRepo.GetEntity<Manager>(15);
			r.AddUser(m);

			UserRepo.UpsertEntity<Role>(r);

			Assert.That(r.Id, Is.GreaterThan(0));
		}

		[Test]
		public void CanSaveManagerWithRolesTest()
		{
			Manager m = new Manager
			{
				FirstName = "Hello",
				LastName = "There",
				Designation = "AnotherOne"
			};
			m.AddRole(new Role { Name = "Some role" });

			UserRepo.UpsertEntity<Manager>(m);

			Assert.That(m.Id, Is.GreaterThan(0));
		}

		[Test]
		[Ignore("OMG the hard-coded ids.")]
		public void DeletingManagerLeavesAssociatedRolesIntactTest()
		{
			Manager m = UserRepo.GetEntity<Manager>(14);
			UserRepo.DeleteEntity<Manager>(m);
			
			Role r = UserRepo.GetEntity<Role>(4);

			Assert.That(r, Is.Not.Null);
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

			UserRepo.UpsertEntity<Customer>(c);

			Assert.That(c.Id, Is.GreaterThan(0));
		}

		[Test]
		public void CanSaveRoleTest()
		{
			Role r = new Role
			{
				Name = "TestRole"
			};

			UserRepo.UpsertEntity<Role>(r);

			Assert.That(r.Id, Is.GreaterThan(0));
		}
	}
}

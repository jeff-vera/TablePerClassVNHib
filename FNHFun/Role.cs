using System;
using System.Collections.Generic;

namespace FNHFun
{
	public class Role : Entity
	{
		public virtual string Name { get; set; }

		public virtual IList<User> AssignedUsers { get; set; }

		public virtual void AddUser(User u)
		{
			if (AssignedUsers == null)
			{
				AssignedUsers = new List<User>();
			}

			AssignedUsers.Add(u);
		}
	}
}

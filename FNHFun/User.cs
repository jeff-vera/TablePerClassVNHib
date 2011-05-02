using System;
using System.Collections.Generic;

namespace FNHFun
{
	public abstract class User : Entity
	{
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual IList<Role> Roles { get; set; }

		public virtual void AddRole(Role r)
		{
			if (Roles == null)
			{
				Roles = new List<Role>();
			}

			Roles.Add(r);
		}
	}
}

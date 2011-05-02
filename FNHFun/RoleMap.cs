using System;
using FluentNHibernate.Mapping;

namespace FNHFun
{
	public class RoleMap : ClassMap<Role>
	{
		public RoleMap()
		{
			Table("Roles");

			Id(x => x.Id)
				.GeneratedBy.Identity();

			Map(x => x.Name);

			HasManyToMany<User>(x => x.AssignedUsers)
				.Table("UserRoles")
				.Cascade.SaveUpdate();
		}
	}
}

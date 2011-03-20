using System;
using FluentNHibernate.Mapping;

namespace FNHFun
{
	public class UserMap : ClassMap<User>
	{
		public UserMap()
		{
			Table("Users");

			Id(x => x.Id)
				.GeneratedBy.Identity();

			Map(x => x.FirstName);
			Map(x => x.LastName);
		}
	}
}

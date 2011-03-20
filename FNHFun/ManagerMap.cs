using System;
using FluentNHibernate.Mapping;

namespace FNHFun
{
	public class ManagerMap : SubclassMap<Manager>
	{
		public ManagerMap()
		{
			Table("Managers");

			Map(x => x.Designation);
		}
	}
}

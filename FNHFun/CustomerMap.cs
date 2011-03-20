using System;
using FluentNHibernate.Mapping;

namespace FNHFun
{
	public class CustomerMap : SubclassMap<Customer>
	{
		public CustomerMap()
		{
			Table("Customers");

			Map(x => x.Level);
		}
	}
}

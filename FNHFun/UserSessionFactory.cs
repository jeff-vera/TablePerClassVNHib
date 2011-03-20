using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;

namespace FNHFun
{
	public class UserSessionFactory
	{
		public static ISessionFactory GetSessionFactory()
		{
			return Fluently.Configure()
				.Database(
					MsSqlConfiguration.MsSql2005
					.ConnectionString(c => c
						.Database("FNHibFun")
						.Server("bringit\\sqlexpress")
						.TrustedConnection())
						)
				.Mappings(m => m
					.FluentMappings.AddFromAssemblyOf<User>()
					.Conventions.Add(
						ForeignKey.Format((x, y) => 
							String.Concat(y.Name, "Id"))))
				.BuildSessionFactory();										
		}
	}
}

using System;
using NHibernate;

namespace FNHFun
{
	public static class UserRepo
	{
		public static void UpsertUser<T>(T user) where T : User
		{
			using (ISession s = 
				UserSessionFactory.GetSessionFactory().OpenSession())
			using (ITransaction tx = s.BeginTransaction())
			{
				s.SaveOrUpdate(user);
				tx.Commit();
			}
		}
	}
}

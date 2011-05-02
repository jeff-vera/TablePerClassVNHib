using System;
using NHibernate;

namespace FNHFun
{
	public static class UserRepo
	{
		public static void UpsertEntity<T>(T entity) where T : Entity
		{
			using (ISession s = 
				UserSessionFactory.GetSessionFactory().OpenSession())
			using (ITransaction tx = s.BeginTransaction())
			{
				s.SaveOrUpdate(entity);
				tx.Commit();
			}
		}

		public static T GetEntity<T>(int id) where T : Entity
		{
			using (ISession s =
				UserSessionFactory.GetSessionFactory().OpenSession())
			{
				return s.Get<T>(id);
			}
		}

		public static void DeleteEntity<T>(T toDelete) where T : Entity
		{
			using (ISession s =
				UserSessionFactory.GetSessionFactory().OpenSession())
			using (ITransaction tx = s.BeginTransaction())
			{
				s.Delete(toDelete);
				tx.Commit();
			}
		}
	}
}

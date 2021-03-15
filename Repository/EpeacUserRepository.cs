using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class EpeacUserRepository : IEpeacUserRepository
	{
		private readonly ApplicationDbContext _db;

		public EpeacUserRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(EpeacUser entity)
		{
			_db.EpeacUsers.Add(entity);
			return Save();
		}

		public bool Delete(EpeacUser entity)
		{
			_db.EpeacUsers.Remove(entity);
			return Save();
		}

		public ICollection<EpeacUser> FindAll()
		{
			var EpeacUsers = _db.EpeacUsers.ToList();
			return EpeacUsers;
		}

		public EpeacUser FindById(int id)
		{
			var EpeacUsers = _db.EpeacUsers.Find(id);
			return EpeacUsers;
		}

		public bool isExists(int id)
		{
			var exists = _db.Faqs.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(EpeacUser entity)
		{
			_db.EpeacUsers.Update(entity);
			return Save();
		}
	}
}

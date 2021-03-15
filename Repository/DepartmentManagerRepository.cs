using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class DepartmentManagerRepository : IDepartmentManagerRepository
	{
		private readonly ApplicationDbContext _db;

		public DepartmentManagerRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(DepartmentManager entity)
		{
			_db.DepartmentManagers.Add(entity);
			return Save();
		}

		public bool Delete(DepartmentManager entity)
		{
			_db.DepartmentManagers.Remove(entity);
			return Save();
		}

		public ICollection<DepartmentManager> FindAll()
		{
			var DepartmentManagers = _db.DepartmentManagers.ToList();
			return DepartmentManagers;
		}

		public DepartmentManager FindById(int id)
		{
			var DepartmentManagers = _db.DepartmentManagers.Find(id);
			return DepartmentManagers;
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

		public bool Update(DepartmentManager entity)
		{
			_db.DepartmentManagers.Update(entity);
			return Save();
		}
	}
}

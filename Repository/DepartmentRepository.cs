using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly ApplicationDbContext _db;

		public DepartmentRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(Department entity)
		{
			_db.Departments.Add(entity);
			return Save();
		}

		public bool Delete(Department entity)
		{
			_db.Departments.Remove(entity);
			return Save();
		}

		public ICollection<Department> FindAll()
		{
			var Departments = _db.Departments.ToList();
			return Departments;
		}

		public Department FindById(int id)
		{
			var Departments = _db.Departments.Find(id);
			return Departments;
		}

		public bool isExists(int id)
		{
			var exists = _db.Departments.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(Department entity)
		{
			_db.Departments.Update(entity);
			return Save();
		}
	}
}

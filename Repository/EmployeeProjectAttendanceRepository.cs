using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class EmployeeProjectAttendanceRepository : IEmployeeProjectAttendanceRepository
	{
		private readonly ApplicationDbContext _db;

		public EmployeeProjectAttendanceRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(EmployeeProjectAttendance entity)
		{
			_db.EmployeeProjectAttendances.Add(entity);
			return Save();
		}

		public bool Delete(EmployeeProjectAttendance entity)
		{
			_db.EmployeeProjectAttendances.Remove(entity);
			return Save();
		}

		public ICollection<EmployeeProjectAttendance> FindAll()
		{
			var EmployeeProjectAttendances = _db.EmployeeProjectAttendances.ToList();
			return EmployeeProjectAttendances;
		}

		public EmployeeProjectAttendance FindById(int id)
		{
			var EmployeeProjectAttendances = _db.EmployeeProjectAttendances.Find(id);
			return EmployeeProjectAttendances;
		}

		public bool isExists(int id)
		{
			var exists = _db.EmployeeProjectAttendances.Any(q => q.employeeId == id );
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(EmployeeProjectAttendance entity)
		{
			_db.EmployeeProjectAttendances.Update(entity);
			return Save();
		}
	}
}

using epeacweb.Contracts;
using epeacweb.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly ApplicationDbContext _db;

		public EmployeeRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(Employee entity)
		{
			_db.Employees.Add(entity);
			return Save();
		}

		public bool Delete(Employee entity)
		{
			_db.Employees.Remove(entity);
			return Save();
		}

		public ICollection<Employee> FindAll()
		{
			var Employees = _db.Employees.ToList();
			return Employees;
		}

		public Employee FindById(int id)
		{
			var Employee = _db.Employees.Find(id);
			return Employee;
		}

		public bool isExists(int id)
		{
			var exists = _db.Employees.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(Employee entity)
		{
			_db.Employees.Update(entity);
			return Save();
		}
	}
}

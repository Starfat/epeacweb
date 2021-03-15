using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class EmployeeTaskRatingRepository : IEmployeeTaskRatingRepository
	{
		private readonly ApplicationDbContext _db;

		public EmployeeTaskRatingRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(EmployeeTaskRating entity)
		{
			_db.EmployeeTaskRatings.Add(entity);
			return Save();
		}

		public bool Delete(EmployeeTaskRating entity)
		{
			_db.EmployeeTaskRatings.Remove(entity);
			return Save();
		}

		public ICollection<EmployeeTaskRating> FindAll()
		{
			var EmployeeTaskRatings = _db.EmployeeTaskRatings.ToList();
			return EmployeeTaskRatings;
		}

		public EmployeeTaskRating FindById(int id)
		{
			var EmployeeTaskRatings = _db.EmployeeTaskRatings.Find(id);
			return EmployeeTaskRatings;
		}

		public bool isExists(int id)
		{
			var exists = _db.EmployeeTaskRatings.Any(q => q.employeeId == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(EmployeeTaskRating entity)
		{
			_db.EmployeeTaskRatings.Update(entity);
			return Save();
		}
	}
}

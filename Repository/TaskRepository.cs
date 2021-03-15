using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace epeacweb.Repository
{
	public class TaskRepository : ITaskRepository
	{
		private readonly ApplicationDbContext _db;

		public TaskRepository(ApplicationDbContext db)
		{
			_db = db;
		}

		public bool Create(Task entity)
		{
			_db.Tasks.Add(entity);
			return Save();
		}

		public bool Delete(Task entity)
		{
			_db.Tasks.Remove(entity);
			return Save();
		}

		public ICollection<Task> FindAll()
		{
			var Tasks = _db.Tasks.ToList();
			return Tasks;
		}

		public Task FindById(int id)
		{
			var Task = _db.Tasks.Find(id);
			return Task;
		}

		public ICollection<Task> GetEmployeesByTask(int id)
		{
			throw new NotImplementedException();
		}

		public bool isExists(int id)
		{
			var exists = _db.Faqs.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return  changes > 0;
		}

		public bool Update(Task entity)
		{
			_db.Tasks.Update(entity);
			return Save();
		}
	}
}

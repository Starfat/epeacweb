using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class ProjectManagerRepository : IProjectManagerRepository
	{
		private readonly ApplicationDbContext _db;

		public ProjectManagerRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(ProjectManager entity)
		{
			_db.ProjectManagers.Add(entity);
			return Save();
		}

		public bool Delete(ProjectManager entity)
		{
			_db.ProjectManagers.Remove(entity);
			return Save();
		}

		public ICollection<ProjectManager> FindAll()
		{
			var ProjectManagers = _db.ProjectManagers.ToList();
			return ProjectManagers;
		}

		public ProjectManager FindById(int id)
		{
			var ProjectManagers = _db.ProjectManagers.Find(id);
			return ProjectManagers;
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

		public bool Update(ProjectManager entity)
		{
			_db.ProjectManagers.Update(entity);
			return Save();
		}
	}
}

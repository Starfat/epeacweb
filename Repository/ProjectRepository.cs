using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class ProjectRepository : IProjectRepository
	{
		private readonly ApplicationDbContext _db;
		public ProjectRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(Project entity)
		{
			_db.Projects.Add(entity);
			return Save();
		}

		public bool Delete(Project entity)
		{
			_db.Projects.Remove(entity);
			return Save();
		}

		public ICollection<Project> FindAll()
		{
			var Projects = _db.Projects.ToList();
			return Projects;
		}

		public Project FindById(int id)
		{
			var Project = _db.Projects.Find(id);
			return Project;
		}

		public bool isExists(int id)
		{
			var exists = _db.Projects.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(Project entity)
		{
			_db.Projects.Update(entity);
			return Save();
		}
	}
}

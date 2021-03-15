using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class ProjectRoleRepository : IProjectRoleRepository
	{
		private readonly ApplicationDbContext _db;
		public ProjectRoleRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(ProjectRole entity)
		{
			_db.ProjectRoles.Add(entity);
			return Save();
		}

		public bool Delete(ProjectRole entity)
		{
			_db.ProjectRoles.Remove(entity);
			return Save();
		}

		public ICollection<ProjectRole> FindAll()
		{
			var ProjectRoles = _db.ProjectRoles.ToList();
			return ProjectRoles;
		}

		public ProjectRole FindById(int id)
		{
			var ProjectRole = _db.ProjectRoles.Find(id);
			return ProjectRole;
		}

		public bool isExists(int id)
		{
			var exists = _db.ProjectRoles.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(ProjectRole entity)
		{
			_db.ProjectRoles.Update(entity);
			return Save();
		}
	}
}

using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class MilestoneRepository : IMilestoneRepository
	{
		private readonly ApplicationDbContext _db;

		public MilestoneRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(Milestone entity)
		{
			_db.Milestones.Add(entity);
			return Save();
		}

		public bool Delete(Milestone entity)
		{
			_db.Milestones.Remove(entity);
			return Save();
		}

		public ICollection<Milestone> FindAll()
		{
			var Milestones = _db.Milestones.ToList();
			return Milestones;
		}

		public Milestone FindById(int id)
		{
			var Milestones = _db.Milestones.Find(id);
			return Milestones;
		}

		public bool isExists(int id)
		{
			var exists = _db.Milestones.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(Milestone entity)
		{
			_db.Milestones.Update(entity);
			return Save();
		}
	}
}

using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class DrivePhraseRepository : IDrivePhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public DrivePhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(DrivePhrase entity)
		{
			_db.DrivePhrases.Add(entity);
			return Save();
		}

		public bool Delete(DrivePhrase entity)
		{
			_db.DrivePhrases.Remove(entity);
			return Save();
		}

		public ICollection<DrivePhrase> FindAll()
		{
			var DrivePhrases = _db.DrivePhrases.ToList();
			return DrivePhrases;
		}

		public DrivePhrase FindById(int id)
		{
			var DrivePhrases = _db.DrivePhrases.Find(id);
			return DrivePhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.DrivePhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(DrivePhrase entity)
		{
			_db.DrivePhrases.Update(entity);
			return Save();
		}
	}
}

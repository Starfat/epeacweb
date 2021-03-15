using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class CreativityPhraseRepository : ICreativityPhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public CreativityPhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(CreativityPhrase entity)
		{
			_db.CreativityPhrases.Add(entity);
			return Save();
		}

		public bool Delete(CreativityPhrase entity)
		{
			_db.CreativityPhrases.Remove(entity);
			return Save();
		}

		public ICollection<CreativityPhrase> FindAll()
		{
			var CreativityPhrases = _db.CreativityPhrases.ToList();
			return CreativityPhrases;
		}

		public CreativityPhrase FindById(int id)
		{
			var CreativityPhrases = _db.CreativityPhrases.Find(id);
			return CreativityPhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.CreativityPhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(CreativityPhrase entity)
		{
			_db.CreativityPhrases.Update(entity);
			return Save();
		}
	}
}

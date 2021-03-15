using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class PunctualityPhraseRepository : IPunctualityPhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public PunctualityPhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(PunctualityPhrase entity)
		{
			_db.PunctualityPhrases.Add(entity);
			return Save();
		}

		public bool Delete(PunctualityPhrase entity)
		{
			_db.PunctualityPhrases.Remove(entity);
			return Save();
		}

		public ICollection<PunctualityPhrase> FindAll()
		{
			var PunctualityPhrases = _db.PunctualityPhrases.ToList();
			return PunctualityPhrases;
		}

		public PunctualityPhrase FindById(int id)
		{
			var PunctualityPhrases = _db.PunctualityPhrases.Find(id);
			return PunctualityPhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.PunctualityPhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(PunctualityPhrase entity)
		{
			_db.PunctualityPhrases.Update(entity);
			return Save();
		}
	}
}

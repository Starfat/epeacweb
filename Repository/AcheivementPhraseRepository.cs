using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class AcheivementPhraseRepository : IAcheivementPhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public AcheivementPhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(AcheivementPhrase entity)
		{
			_db.AcheivementPhrases.Add(entity);
			return Save();
		}

		public bool Delete(AcheivementPhrase entity)
		{
			_db.AcheivementPhrases.Remove(entity);
			return Save();
		}

		public ICollection<AcheivementPhrase> FindAll()
		{
			var AcheivementPhrases = _db.AcheivementPhrases.ToList();
			return AcheivementPhrases;
		}

		public AcheivementPhrase FindById(int id)
		{
			var AcheivementPhrases = _db.AcheivementPhrases.Find(id);
			return AcheivementPhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.AcheivementPhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(AcheivementPhrase entity)
		{
			_db.AcheivementPhrases.Update(entity);
			return Save();
		}
	}
}

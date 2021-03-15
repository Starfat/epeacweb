using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class CooperationPhraseRepository : ICooperationPhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public CooperationPhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(CooperationPhrase entity)
		{
			_db.CooperationPhrases.Add(entity);
			return Save();
		}

		public bool Delete(CooperationPhrase entity)
		{
			_db.CooperationPhrases.Remove(entity);
			return Save();
		}

		public ICollection<CooperationPhrase> FindAll()
		{
			var CooperationPhrases = _db.CooperationPhrases.ToList();
			return CooperationPhrases;
		}

		public CooperationPhrase FindById(int id)
		{
			var CooperationPhrases = _db.CooperationPhrases.Find(id);
			return CooperationPhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.CooperationPhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(CooperationPhrase entity)
		{
			_db.CooperationPhrases.Update(entity);
			return Save();
		}
	}
}

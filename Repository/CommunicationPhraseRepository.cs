using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class CommunicationPhraseRepository : ICommunicationPhraseRepository
	{
		private readonly ApplicationDbContext _db;

		public CommunicationPhraseRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(CommunicationPhrase entity)
		{
			_db.CommunicationPhrases.Add(entity);
			return Save();
		}

		public bool Delete(CommunicationPhrase entity)
		{
			_db.CommunicationPhrases.Remove(entity);
			return Save();
		}

		public ICollection<CommunicationPhrase> FindAll()
		{
			var CommunicationPhrases = _db.CommunicationPhrases.ToList();
			return CommunicationPhrases;
		}

		public CommunicationPhrase FindById(int id)
		{
			var CommunicationPhrases = _db.CommunicationPhrases.Find(id);
			return CommunicationPhrases;
		}

		public bool isExists(int id)
		{
			var exists = _db.CommunicationPhrases.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(CommunicationPhrase entity)
		{
			_db.CommunicationPhrases.Update(entity);
			return Save();
		}
	}
}

using epeacweb.Contracts;
using epeacweb.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class FaqRepository : IFaqRepository
	{
		private readonly ApplicationDbContext _db;

		public FaqRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(Faq entity)
		{
			_db.Faqs.Add(entity);
			return Save();
		}

		public bool Delete(Faq entity)
		{
			_db.Faqs.Remove(entity);
			return Save();
		}

		public ICollection<Faq> FindAll()
		{
			var Faqs = _db.Faqs.ToList();
			return Faqs;
		}

		public Faq FindById(int id)
		{
			var Faq = _db.Faqs.Find(id);
			return Faq;
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

		public bool Update(Faq entity)
		{
			_db.Faqs.Update(entity);
			return Save();
		}
	}
}

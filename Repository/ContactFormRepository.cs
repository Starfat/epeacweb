using epeacweb.Contracts;
using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Repository
{
	public class ContactFormRepository : IContactFormRepository
	{
		private readonly ApplicationDbContext _db;

		public ContactFormRepository(ApplicationDbContext db)
		{
			_db = db;
		}
		public bool Create(ContactForm entity)
		{
			_db.ContactForms.Add(entity);
			return Save();
		}

		public bool Delete(ContactForm entity)
		{
			_db.ContactForms.Remove(entity);
			return Save();
		}

		public ICollection<ContactForm> FindAll()
		{
			var ContactForms = _db.ContactForms.ToList();
			return ContactForms;
		}

		public ContactForm FindById(int id)
		{
			var ContactForms = _db.ContactForms.Find(id);
			return ContactForms;
		}

		public bool isExists(int id)
		{
			var exists = _db.ContactForms.Any(q => q.Id == id);
			return exists;
		}

		public bool Save()
		{
			var changes = _db.SaveChanges();
			return changes > 0;
		}

		public bool Update(ContactForm entity)
		{
			_db.ContactForms.Update(entity);
			return Save();
		}
	}
}

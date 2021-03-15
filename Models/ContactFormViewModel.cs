using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class ContactFormViewModel
	{
		public int Id { get; set; }
		public string fromEmail { get; set; }
		public string messageTitle { get; set; }
		public string message { get; set; }
		public bool isRead { get; set; }
		public bool isCompleted { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class ContactForm
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string fromEmail { get; set; }
		public string messageTitle { get; set; }
		public string message { get; set; }
		public bool isRead { get; set; }
		public bool isCompleted { get; set; }

	}
}

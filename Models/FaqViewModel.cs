using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class FaqViewModel
	{
		public int Id { get; set; }
		public string faqTitle { get; set; }
		public string faqDescription { get; set; }
	}
}

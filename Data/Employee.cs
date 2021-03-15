using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("departmentId")]
		public Department Department { get; set; }
		public int? departmentId { get; set; }

		[ForeignKey("userId")]
		public EpeacUser EpeacUser { get; set; }
		public string userId { get; set; }
	}
}

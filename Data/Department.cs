using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class Department
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string departmentName { get; set; }
		public string departmentDescription { get; set; }

		[ForeignKey("departmentManagerId")]
		public DepartmentManager DepartmentManager { get; set; }
		public int? departmentManagerId { get; set; }
	}
}

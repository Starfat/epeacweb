using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class Project
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("projectManagerId")]
		public ProjectManager ProjectManager { get; set; }
		public int? projectManagerId { get; set; }

		[ForeignKey("departmentId")]
		public Department Department { get; set; }
		public int departmentId { get; set; }
		public string projectName { get; set; }
		public string projectDescription { get; set; }
		public DateTime? projectStartDate { get; set; }
		public DateTime? projectEndDate { get; set; }
		public int? projectStatus { get; set; }

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace epeacweb.Data
{
	public class Task
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("projectId")]
		public Project Project { get; set; }
		public int projectId { get; set; }

		[ForeignKey("employeeId")]
		public Employee Employee { get; set; }
		public int? employeeId { get; set; }

		[Required]
		public string taskName { get; set; }
		public string taskDescription { get; set; }
		public DateTime? taskStartDate { get; set; }
		public DateTime? taskEndDate { get; set; }
		public int? taskStatus { get; set; }
		public int? totalRating { get; set; }


	}
}

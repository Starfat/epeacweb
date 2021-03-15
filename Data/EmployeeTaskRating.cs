using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class EmployeeTaskRating
	{
		[ForeignKey("employeeId")]
		public Employee Employee { get; set; }
		public int employeeId { get; set; }

		[ForeignKey("taskId")]
		public Task Task { get; set; }
		public int taskId { get; set; }

		public int rating { get; set; }

		public string review { get; set; }
	}
}

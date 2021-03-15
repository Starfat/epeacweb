using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class EmployeeTaskRatingViewModel
	{
		public EmployeeViewModel Employee { get; set; }
		public int employeeId { get; set; }

		public TaskViewModel Task { get; set; }
		public int taskId { get; set; }

		public int rating { get; set; }

		public string review { get; set; }
	}
}

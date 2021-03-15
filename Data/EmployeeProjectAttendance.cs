using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class EmployeeProjectAttendance
	{
		[ForeignKey("employeeId")]
		public Employee Employee { get; set; }
		public int employeeId { get; set; }

		[ForeignKey("projectId")]
		public Project Project { get; set; }
		public int projectId { get; set; }

		[ForeignKey("roleId")]
		public ProjectRole ProjectRole { get; set; }
		public int roleId { get; set; }
	}
}

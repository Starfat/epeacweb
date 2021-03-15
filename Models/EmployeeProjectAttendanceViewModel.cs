using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class EmployeeProjectAttendanceViewModel
	{
		public EmployeeViewModel Employee { get; set; }
		public int employeeId { get; set; }

		public ProjectViewModel Project { get; set; }
		public int projectId { get; set; }

		public ProjectRoleViewModel ProjectRole { get; set; }
		public int roleId { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class DepartmentManagerViewModel
	{
		public int Id { get; set; }
		public EmployeeViewModel Employee { get; set; }
		public int employeeId { get; set; }
	}
}

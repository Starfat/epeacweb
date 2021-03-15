using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }
		public DepartmentViewModel Department { get; set; }
		public int departmentId { get; set; }
		public EpeacUserViewModel EpeacUser { get; set; }
		public string userId { get; set; }
	}
}

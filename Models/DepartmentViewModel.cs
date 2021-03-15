using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }
		public string departmentName { get; set; }
		public string departmentDescription { get; set; }
		public DepartmentManagerViewModel DepartmentManager { get; set; }
		public int? departmentManagerId { get; set; }
	}
}

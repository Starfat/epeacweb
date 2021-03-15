using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class ProjectViewModel
	{
		public int Id { get; set; }
		public ProjectManagerViewModel ProjectManager { get; set; }
		public int projectManagerId { get; set; }

		public DepartmentViewModel Department { get; set; }
		public int departmentId { get; set; }
		public string projectName { get; set; }
		public string projectDescription { get; set; }
		public DateTime projectStartDate { get; set; }
		public DateTime projectEndDate { get; set; }
		public int projectStatus { get; set; }
	}
}

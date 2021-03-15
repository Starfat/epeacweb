using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace epeacweb.Models
{
	public class TaskViewModel
	{
		public int Id { get; set; }
		public ProjectViewModel Project { get; set; }
		public int projectId { get; set; }
		public EmployeeViewModel Employee { get; set; }
		public int employeeId { get; set; }
		[Display(Name = "Name")]
		public string taskName { get; set; }
		[Display(Name="Description")]
		public string taskDescription { get; set; }
		[Display(Name = "Start Date")]
		public DateTime taskStartDate { get; set; }
		[Display(Name = "End Date")]
		public DateTime taskEndDate { get; set; }
		[Display(Name = "Status")]
		public int taskStatus { get; set; }
		[Display(Name = "Total Rating")]
		public int totalRating { get; set; }
	}
}

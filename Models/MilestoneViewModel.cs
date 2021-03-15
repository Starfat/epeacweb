using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class MilestoneViewModel
	{
		public int Id { get; set; }
		public TaskViewModel Task { get; set; }
		public int taskId { get; set; }
		public string milestoneName { get; set; }
		public string milestoneDescription { get; set; }
		public DateTime? milestoneDate { get; set; }
		public bool milestoneAchieved { get; set; }
		public string PMAchievementComment { get; set; }
	}
}

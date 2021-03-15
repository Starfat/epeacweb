using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class Milestone
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("taskId")]
		public Task Task { get; set; }
		public int taskId { get; set; }
		public string milestoneName { get; set; }
		public string milestoneDescription { get; set; }
		public DateTime? milestoneDate { get; set; }
		public bool milestoneAchieved { get; set; }
		public string PMAchievementComment { get; set; }
	}
}

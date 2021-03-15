using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class PerformanceEvaluation
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string evaluationComment { get; set; }

		public DateTime? evaluationPeriodStart { get; set; }
		public DateTime? evaluationPeriodEnd { get; set; }

		[ForeignKey("employeeId")]
		public Employee Employee { get; set; }
		public int employeeId { get; set; }

		[ForeignKey("departmentManagerId")]
		public DepartmentManager DepartmentManager { get; set; }
		public int? departmentManagerId { get; set; }

		[ForeignKey("cooperationPhraseId")]
		public CooperationPhrase CooperationPhrase { get; set; }
		public int? cooperationPhraseId { get; set; }

		[ForeignKey("communicationPhraseId")]
		public CommunicationPhrase CommunicationPhrase { get; set; }
		public int? communicationPhraseId { get; set; }

		[ForeignKey("drivePhraseId")]
		public DrivePhrase	DrivePhrase { get; set; }
		public int? drivePhraseId { get; set; }

		[ForeignKey("creativityPhraseId")]
		public CreativityPhrase CreativityPhrase { get; set; }
		public int? creativityPhraseId { get; set; }

		[ForeignKey("punctualityPhraseId")]
		public PunctualityPhrase PunctualityPhrase { get; set; }
		public int? punctualityPhraseId { get; set; }

		[ForeignKey("acheivementPhraseId")]
		public AcheivementPhrase AcheivementPhrase { get; set; }
		public int? acheivementPhraseId { get; set; }

	}
}

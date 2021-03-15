using System;
using System.Collections.Generic;
using System.Text;
using epeacweb.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using epeacweb.Models;

namespace epeacweb.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EmployeeProjectAttendance>().HasKey(epa => new { epa.employeeId, epa.projectId });
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<EmployeeTaskRating>().HasKey(etr => new { etr.employeeId, etr.taskId });
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<EpeacUser> EpeacUsers { get; set; }
		public DbSet<ProjectManager> ProjectManagers { get; set; }
		public DbSet<DepartmentManager> DepartmentManagers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<CooperationPhrase> CooperationPhrases { get; set; }
		public DbSet<CommunicationPhrase> CommunicationPhrases { get; set; }
		public DbSet<DrivePhrase> DrivePhrases { get; set; }
		public DbSet<CreativityPhrase> CreativityPhrases { get; set; }
		public DbSet<PunctualityPhrase> PunctualityPhrases { get; set; }
		public DbSet<AcheivementPhrase> AcheivementPhrases { get; set; }
		public DbSet<PerformanceEvaluation> PerformanceEvaluations { get; set; }
		public DbSet<ActivityLog> ActivityLogs { get; set; }
		public DbSet<ContactForm> ContactForms { get; set; }
		public DbSet<ProjectRole> ProjectRoles { get; set; }
		public DbSet<Faq> Faqs { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Task> Tasks { get; set; }
		public DbSet<Milestone> Milestones { get; set; }
		public DbSet<EmployeeProjectAttendance> EmployeeProjectAttendances { get; set; }
		public DbSet<EmployeeTaskRating> EmployeeTaskRatings { get; set; }
		public DbSet<epeacweb.Models.FaqViewModel> FaqViewModel { get; set; }
		public DbSet<epeacweb.Models.TaskViewModel> TaskViewModel { get; set; }
		public DbSet<epeacweb.Models.ProjectViewModel> ProjectViewModel { get; set; }
		public DbSet<epeacweb.Models.DepartmentViewModel> DepartmentViewModel { get; set; }
		public DbSet<epeacweb.Models.DepartmentManagerViewModel> DepartmentManagerViewModel { get; set; }
		public DbSet<epeacweb.Models.EpeacUserViewModel> EpeacUserViewModel { get; set; }
		public DbSet<epeacweb.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
		public DbSet<epeacweb.Models.ProjectManagerViewModel> ProjectManagerViewModel { get; set; }
		public DbSet<epeacweb.Models.CommunicationPhraseViewModel> CommunicationPhraseViewModel { get; set; }
		public DbSet<epeacweb.Models.ContactFormViewModel> ContactFormViewModel { get; set; }
		public DbSet<epeacweb.Models.ProjectRoleViewModel> ProjectRoleViewModel { get; set; }
		public DbSet<epeacweb.Models.MilestoneViewModel> MilestoneViewModel { get; set; }
	}
}

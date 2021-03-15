using AutoMapper;
using epeacweb.Data;
using epeacweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Mappings
{
	public class Maps : Profile
	{
		public Maps()
		{
			CreateMap<DepartmentManager, DepartmentManagerViewModel>().ReverseMap();
			CreateMap<Department, DepartmentViewModel>().ReverseMap();
			CreateMap<Employee, EmployeeViewModel>().ReverseMap();
			CreateMap<EpeacUser, EpeacUserViewModel>().ReverseMap();
			CreateMap<Faq, FaqViewModel>().ReverseMap();
			CreateMap<ProjectManager, ProjectManagerViewModel>().ReverseMap();
			CreateMap<Project, ProjectViewModel>().ReverseMap();
			CreateMap<Data.Task, TaskViewModel>().ReverseMap();
			CreateMap<CommunicationPhrase, CommunicationPhraseViewModel>().ReverseMap();
			CreateMap<CooperationPhrase, CooperationPhraseViewModel>().ReverseMap();
			CreateMap<CreativityPhrase, CreativityPhraseViewModel>().ReverseMap();
			CreateMap<PunctualityPhrase, PunctualityPhraseViewModel>().ReverseMap();
			CreateMap<DrivePhrase, DrivePhraseViewModel>().ReverseMap();
			CreateMap<AcheivementPhrase, AcheivementPhraseViewModel>().ReverseMap();
			CreateMap<ContactForm, ContactFormViewModel>().ReverseMap();
			CreateMap<ProjectRole, ProjectRoleViewModel>().ReverseMap();
			CreateMap<Milestone, MilestoneViewModel>().ReverseMap();
			CreateMap<EmployeeTaskRating, EmployeeTaskRatingViewModel>().ReverseMap();
			CreateMap<EmployeeProjectAttendance, EmployeeProjectAttendanceViewModel>().ReverseMap();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using epeacweb.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using epeacweb.Contracts;
using epeacweb.Repository;
using AutoMapper;
using epeacweb.Mappings;

namespace epeacweb
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			// Added references to Repository and Contracts
			services.AddScoped<IDepartmentManagerRepository, DepartmentManagerRepository>();
			services.AddScoped<IDepartmentRepository, DepartmentRepository>();
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IEpeacUserRepository, EpeacUserRepository>();
			services.AddScoped<IFaqRepository, FaqRepository>();
			services.AddScoped<IProjectManagerRepository, ProjectManagerRepository>();
			services.AddScoped<IProjectRepository, ProjectRepository>();
			services.AddScoped<ITaskRepository, TaskRepository>();
			services.AddScoped<ICommunicationPhraseRepository, CommunicationPhraseRepository>();
			services.AddScoped<ICooperationPhraseRepository, CooperationPhraseRepository>();
			services.AddScoped<ICreativityPhraseRepository, CreativityPhraseRepository>();
			services.AddScoped<IPunctualityPhraseRepository, PunctualityPhraseRepository>();
			services.AddScoped<IDrivePhraseRepository, DrivePhraseRepository>();
			services.AddScoped<IAcheivementPhraseRepository, AcheivementPhraseRepository>();
			services.AddScoped<IContactFormRepository, ContactFormRepository>();
			services.AddScoped<IEmployeeProjectAttendanceRepository, EmployeeProjectAttendanceRepository>();
			services.AddScoped<IProjectRoleRepository, ProjectRoleRepository>();
			services.AddScoped<IEmployeeTaskRatingRepository, EmployeeTaskRatingRepository>();
			services.AddScoped<IMilestoneRepository, MilestoneRepository>();

			services.AddAutoMapper(typeof(Maps));

			services.AddDefaultIdentity<IdentityUser>(options => { options.SignIn.RequireConfirmedAccount = true; })
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddControllersWithViews();
			services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using epeacweb.Data;

namespace epeacweb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200416201543_fasId")]
    partial class fasId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("epeacweb.Data.AcheivementPhrase", b =>
                {
                    b.Property<int>("acheivementPhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("acheivementPhraseId");

                    b.ToTable("AcheivementPhrases");
                });

            modelBuilder.Entity("epeacweb.Data.ActivityLog", b =>
                {
                    b.Property<int>("logId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clientIP")
                        .HasColumnType("int");

                    b.Property<string>("logType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("timeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("logId");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("epeacweb.Data.CommunicationPhrase", b =>
                {
                    b.Property<int>("communicationPhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("communicationPhraseId");

                    b.ToTable("CommunicationPhrases");
                });

            modelBuilder.Entity("epeacweb.Data.ContactForm", b =>
                {
                    b.Property<int>("messageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fromEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageId");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("epeacweb.Data.CooperationPhrase", b =>
                {
                    b.Property<int>("cooperationPhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("cooperationPhraseId");

                    b.ToTable("CooperationPhrases");
                });

            modelBuilder.Entity("epeacweb.Data.CreativityPhrase", b =>
                {
                    b.Property<int>("creativityPhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("creativityPhraseId");

                    b.ToTable("CreativityPhrases");
                });

            modelBuilder.Entity("epeacweb.Data.Department", b =>
                {
                    b.Property<int>("departmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentManagerId")
                        .HasColumnType("int");

                    b.Property<string>("departmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentId");

                    b.HasIndex("departmentManagerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("epeacweb.Data.DepartmentManager", b =>
                {
                    b.Property<int>("departmentManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.HasKey("departmentManagerId");

                    b.HasIndex("employeeId");

                    b.ToTable("DepartmentManagers");
                });

            modelBuilder.Entity("epeacweb.Data.DrivePhrase", b =>
                {
                    b.Property<int>("drivePhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("drivePhraseId");

                    b.ToTable("DrivePhrases");
                });

            modelBuilder.Entity("epeacweb.Data.Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("employeeId");

                    b.HasIndex("departmentId");

                    b.HasIndex("userId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("epeacweb.Data.EmployeeProjectAttendance", b =>
                {
                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("employeeId", "projectId");

                    b.HasIndex("projectId");

                    b.HasIndex("roleId");

                    b.ToTable("EmployeeProjectAttendances");
                });

            modelBuilder.Entity("epeacweb.Data.EmployeeTaskRating", b =>
                {
                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("taskId")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<string>("review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeId", "taskId");

                    b.HasIndex("taskId");

                    b.ToTable("EmployeeTaskRatings");
                });

            modelBuilder.Entity("epeacweb.Data.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("faqDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faqTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("epeacweb.Data.Milestone", b =>
                {
                    b.Property<int>("milestoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PMAchievementComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("milestoneAchieved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("milestoneDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("milestoneDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("milestoneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("taskId")
                        .HasColumnType("int");

                    b.HasKey("milestoneId");

                    b.HasIndex("taskId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("epeacweb.Data.PerformanceEvaluation", b =>
                {
                    b.Property<int>("evaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("acheivementPhraseId")
                        .HasColumnType("int");

                    b.Property<int?>("communicationPhraseId")
                        .HasColumnType("int");

                    b.Property<int?>("cooperationPhraseId")
                        .HasColumnType("int");

                    b.Property<int?>("creativityPhraseId")
                        .HasColumnType("int");

                    b.Property<int?>("departmentManagerId")
                        .HasColumnType("int");

                    b.Property<int?>("drivePhraseId")
                        .HasColumnType("int");

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<string>("evaluationComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("evaluationPeriodEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("evaluationPeriodStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("punctualityPhraseId")
                        .HasColumnType("int");

                    b.HasKey("evaluationId");

                    b.HasIndex("acheivementPhraseId");

                    b.HasIndex("communicationPhraseId");

                    b.HasIndex("cooperationPhraseId");

                    b.HasIndex("creativityPhraseId");

                    b.HasIndex("departmentManagerId");

                    b.HasIndex("drivePhraseId");

                    b.HasIndex("employeeId");

                    b.HasIndex("punctualityPhraseId");

                    b.ToTable("PerformanceEvaluations");
                });

            modelBuilder.Entity("epeacweb.Data.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("projectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("projectEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("projectManagerId")
                        .HasColumnType("int");

                    b.Property<string>("projectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("projectStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("projectStatus")
                        .HasColumnType("int");

                    b.HasKey("projectId");

                    b.HasIndex("departmentId");

                    b.HasIndex("projectManagerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("epeacweb.Data.ProjectManager", b =>
                {
                    b.Property<int>("projectManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.HasKey("projectManagerId");

                    b.HasIndex("employeeId");

                    b.ToTable("ProjectManagers");
                });

            modelBuilder.Entity("epeacweb.Data.ProjectRole", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("roleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("ProjectRoles");
                });

            modelBuilder.Entity("epeacweb.Data.PunctualityPhrase", b =>
                {
                    b.Property<int>("punctualityPhraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("phraseText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phraseValue")
                        .HasColumnType("int");

                    b.HasKey("punctualityPhraseId");

                    b.ToTable("PunctualityPhrases");
                });

            modelBuilder.Entity("epeacweb.Data.Task", b =>
                {
                    b.Property<int>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<string>("taskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("taskEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("taskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("taskStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("taskStatus")
                        .HasColumnType("int");

                    b.Property<int?>("totalRating")
                        .HasColumnType("int");

                    b.HasKey("taskId");

                    b.HasIndex("employeeId");

                    b.HasIndex("projectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("epeacweb.Data.EpeacUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("EpeacUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.Department", b =>
                {
                    b.HasOne("epeacweb.Data.DepartmentManager", "DepartmentManager")
                        .WithMany()
                        .HasForeignKey("departmentManagerId");
                });

            modelBuilder.Entity("epeacweb.Data.DepartmentManager", b =>
                {
                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.Employee", b =>
                {
                    b.HasOne("epeacweb.Data.Department", "Department")
                        .WithMany()
                        .HasForeignKey("departmentId");

                    b.HasOne("epeacweb.Data.EpeacUser", "EpeacUser")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("epeacweb.Data.EmployeeProjectAttendance", b =>
                {
                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epeacweb.Data.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epeacweb.Data.ProjectRole", "ProjectRole")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.EmployeeTaskRating", b =>
                {
                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epeacweb.Data.Task", "Task")
                        .WithMany()
                        .HasForeignKey("taskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.Milestone", b =>
                {
                    b.HasOne("epeacweb.Data.Task", "Task")
                        .WithMany()
                        .HasForeignKey("taskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.PerformanceEvaluation", b =>
                {
                    b.HasOne("epeacweb.Data.AcheivementPhrase", "AcheivementPhrase")
                        .WithMany()
                        .HasForeignKey("acheivementPhraseId");

                    b.HasOne("epeacweb.Data.CommunicationPhrase", "CommunicationPhrase")
                        .WithMany()
                        .HasForeignKey("communicationPhraseId");

                    b.HasOne("epeacweb.Data.CooperationPhrase", "CooperationPhrase")
                        .WithMany()
                        .HasForeignKey("cooperationPhraseId");

                    b.HasOne("epeacweb.Data.CreativityPhrase", "CreativityPhrase")
                        .WithMany()
                        .HasForeignKey("creativityPhraseId");

                    b.HasOne("epeacweb.Data.DepartmentManager", "DepartmentManager")
                        .WithMany()
                        .HasForeignKey("departmentManagerId");

                    b.HasOne("epeacweb.Data.DrivePhrase", "DrivePhrase")
                        .WithMany()
                        .HasForeignKey("drivePhraseId");

                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epeacweb.Data.PunctualityPhrase", "PunctualityPhrase")
                        .WithMany()
                        .HasForeignKey("punctualityPhraseId");
                });

            modelBuilder.Entity("epeacweb.Data.Project", b =>
                {
                    b.HasOne("epeacweb.Data.Department", "Department")
                        .WithMany()
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epeacweb.Data.ProjectManager", "ProjectManager")
                        .WithMany()
                        .HasForeignKey("projectManagerId");
                });

            modelBuilder.Entity("epeacweb.Data.ProjectManager", b =>
                {
                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epeacweb.Data.Task", b =>
                {
                    b.HasOne("epeacweb.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.HasOne("epeacweb.Data.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

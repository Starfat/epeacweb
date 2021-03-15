using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace epeacweb.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcheivementPhrases",
                columns: table => new
                {
                    acheivementPhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcheivementPhrases", x => x.acheivementPhraseId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    logId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logType = table.Column<string>(nullable: true),
                    timeStamp = table.Column<DateTime>(nullable: false),
                    clientIP = table.Column<int>(nullable: false),
                    userName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.logId);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationPhrases",
                columns: table => new
                {
                    communicationPhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationPhrases", x => x.communicationPhraseId);
                });

            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    messageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromEmail = table.Column<string>(nullable: true),
                    messageTitle = table.Column<string>(nullable: true),
                    message = table.Column<string>(nullable: true),
                    isRead = table.Column<bool>(nullable: false),
                    isCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.messageId);
                });

            migrationBuilder.CreateTable(
                name: "CooperationPhrases",
                columns: table => new
                {
                    cooperationPhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooperationPhrases", x => x.cooperationPhraseId);
                });

            migrationBuilder.CreateTable(
                name: "CreativityPhrases",
                columns: table => new
                {
                    creativityPhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreativityPhrases", x => x.creativityPhraseId);
                });

            migrationBuilder.CreateTable(
                name: "DrivePhrases",
                columns: table => new
                {
                    drivePhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivePhrases", x => x.drivePhraseId);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    faqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faqTitle = table.Column<string>(nullable: true),
                    faqDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.faqId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRoles",
                columns: table => new
                {
                    roleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRoles", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    projectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectManagerId = table.Column<int>(nullable: true),
                    departmentId = table.Column<int>(nullable: false),
                    projectName = table.Column<string>(nullable: true),
                    projectDescription = table.Column<string>(nullable: true),
                    projectStartDate = table.Column<DateTime>(nullable: true),
                    projectEndDate = table.Column<DateTime>(nullable: true),
                    projectStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.projectId);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectManagers_projectManagerId",
                        column: x => x.projectManagerId,
                        principalTable: "ProjectManagers",
                        principalColumn: "projectManagerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PunctualityPhrases",
                columns: table => new
                {
                    punctualityPhraseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phraseText = table.Column<string>(nullable: true),
                    phraseValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunctualityPhrases", x => x.punctualityPhraseId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjectAttendances",
                columns: table => new
                {
                    employeeId = table.Column<int>(nullable: false),
                    projectId = table.Column<int>(nullable: false),
                    roleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjectAttendances", x => new { x.employeeId, x.projectId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjectAttendances_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectAttendances_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectAttendances_ProjectRoles_roleId",
                        column: x => x.roleId,
                        principalTable: "ProjectRoles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    taskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(nullable: false),
                    employeeId = table.Column<int>(nullable: true),
                    taskName = table.Column<string>(nullable: false),
                    taskDescription = table.Column<string>(nullable: true),
                    taskStartDate = table.Column<DateTime>(nullable: true),
                    taskEndDate = table.Column<DateTime>(nullable: true),
                    taskStatus = table.Column<int>(nullable: true),
                    totalRating = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.taskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_projectId",
                        column: x => x.projectId,
                        principalTable: "Projects",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceEvaluations",
                columns: table => new
                {
                    evaluationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    evaluationComment = table.Column<string>(nullable: true),
                    evaluationPeriodStart = table.Column<DateTime>(nullable: true),
                    evaluationPeriodEnd = table.Column<DateTime>(nullable: true),
                    employeeId = table.Column<int>(nullable: false),
                    departmentManagerId = table.Column<int>(nullable: true),
                    cooperationPhraseId = table.Column<int>(nullable: true),
                    communicationPhraseId = table.Column<int>(nullable: true),
                    drivePhraseId = table.Column<int>(nullable: true),
                    creativityPhraseId = table.Column<int>(nullable: true),
                    punctualityPhraseId = table.Column<int>(nullable: true),
                    acheivementPhraseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceEvaluations", x => x.evaluationId);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_AcheivementPhrases_acheivementPhraseId",
                        column: x => x.acheivementPhraseId,
                        principalTable: "AcheivementPhrases",
                        principalColumn: "acheivementPhraseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_CommunicationPhrases_communicationPhraseId",
                        column: x => x.communicationPhraseId,
                        principalTable: "CommunicationPhrases",
                        principalColumn: "communicationPhraseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_CooperationPhrases_cooperationPhraseId",
                        column: x => x.cooperationPhraseId,
                        principalTable: "CooperationPhrases",
                        principalColumn: "cooperationPhraseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_CreativityPhrases_creativityPhraseId",
                        column: x => x.creativityPhraseId,
                        principalTable: "CreativityPhrases",
                        principalColumn: "creativityPhraseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_DepartmentManagers_departmentManagerId",
                        column: x => x.departmentManagerId,
                        principalTable: "DepartmentManagers",
                        principalColumn: "departmentManagerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_DrivePhrases_drivePhraseId",
                        column: x => x.drivePhraseId,
                        principalTable: "DrivePhrases",
                        principalColumn: "drivePhraseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerformanceEvaluations_PunctualityPhrases_punctualityPhraseId",
                        column: x => x.punctualityPhraseId,
                        principalTable: "PunctualityPhrases",
                        principalColumn: "punctualityPhraseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTaskRatings",
                columns: table => new
                {
                    employeeId = table.Column<int>(nullable: false),
                    taskId = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false),
                    review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaskRatings", x => new { x.employeeId, x.taskId });
                    table.ForeignKey(
                        name: "FK_EmployeeTaskRatings_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTaskRatings_Tasks_taskId",
                        column: x => x.taskId,
                        principalTable: "Tasks",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    milestoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskId = table.Column<int>(nullable: false),
                    milestoneName = table.Column<string>(nullable: true),
                    milestoneDescription = table.Column<string>(nullable: true),
                    milestoneDate = table.Column<DateTime>(nullable: true),
                    milestoneAchieved = table.Column<bool>(nullable: false),
                    PMAchievementComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.milestoneId);
                    table.ForeignKey(
                        name: "FK_Milestones_Tasks_taskId",
                        column: x => x.taskId,
                        principalTable: "Tasks",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectAttendances_projectId",
                table: "EmployeeProjectAttendances",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectAttendances_roleId",
                table: "EmployeeProjectAttendances",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaskRatings_taskId",
                table: "EmployeeTaskRatings",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_taskId",
                table: "Milestones",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_acheivementPhraseId",
                table: "PerformanceEvaluations",
                column: "acheivementPhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_communicationPhraseId",
                table: "PerformanceEvaluations",
                column: "communicationPhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_cooperationPhraseId",
                table: "PerformanceEvaluations",
                column: "cooperationPhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_creativityPhraseId",
                table: "PerformanceEvaluations",
                column: "creativityPhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_departmentManagerId",
                table: "PerformanceEvaluations",
                column: "departmentManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_drivePhraseId",
                table: "PerformanceEvaluations",
                column: "drivePhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_employeeId",
                table: "PerformanceEvaluations",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceEvaluations_punctualityPhraseId",
                table: "PerformanceEvaluations",
                column: "punctualityPhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_departmentId",
                table: "Projects",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_projectManagerId",
                table: "Projects",
                column: "projectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_employeeId",
                table: "Tasks",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_projectId",
                table: "Tasks",
                column: "projectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropTable(
                name: "EmployeeProjectAttendances");

            migrationBuilder.DropTable(
                name: "EmployeeTaskRatings");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropTable(
                name: "PerformanceEvaluations");

            migrationBuilder.DropTable(
                name: "ProjectRoles");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AcheivementPhrases");

            migrationBuilder.DropTable(
                name: "CommunicationPhrases");

            migrationBuilder.DropTable(
                name: "CooperationPhrases");

            migrationBuilder.DropTable(
                name: "CreativityPhrases");

            migrationBuilder.DropTable(
                name: "DrivePhrases");

            migrationBuilder.DropTable(
                name: "PunctualityPhrases");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}

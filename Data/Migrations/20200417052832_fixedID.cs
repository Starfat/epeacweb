using Microsoft.EntityFrameworkCore.Migrations;

namespace epeacweb.Data.Migrations
{
    public partial class fixedID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentManagers_Employees_employeeId",
                table: "DepartmentManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_DepartmentManagers_departmentManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_Employees_employeeId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_Projects_projectId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_ProjectRoles_roleId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskRatings_Employees_employeeId",
                table: "EmployeeTaskRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskRatings_Tasks_taskId",
                table: "EmployeeTaskRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Tasks_taskId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_AcheivementPhrases_acheivementPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CommunicationPhrases_communicationPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CooperationPhrases_cooperationPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CreativityPhrases_creativityPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_DepartmentManagers_departmentManagerId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_DrivePhrases_drivePhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_Employees_employeeId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_PunctualityPhrases_punctualityPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagers_Employees_employeeId",
                table: "ProjectManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_departmentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectManagers_projectManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_employeeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_projectId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PunctualityPhrases",
                table: "PunctualityPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectManagers",
                table: "ProjectManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformanceEvaluations",
                table: "PerformanceEvaluations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrivePhrases",
                table: "DrivePhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreativityPhrases",
                table: "CreativityPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooperationPhrases",
                table: "CooperationPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactForms",
                table: "ContactForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationPhrases",
                table: "CommunicationPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivityLogs",
                table: "ActivityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcheivementPhrases",
                table: "AcheivementPhrases");

            migrationBuilder.DropColumn(
                name: "taskId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "punctualityPhraseId",
                table: "PunctualityPhrases");

            migrationBuilder.DropColumn(
                name: "projectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "roleId",
                table: "ProjectRoles");

            migrationBuilder.DropColumn(
                name: "projectManagerId",
                table: "ProjectManagers");

            migrationBuilder.DropColumn(
                name: "evaluationId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropColumn(
                name: "milestoneId",
                table: "Milestones");

            migrationBuilder.DropColumn(
                name: "employeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "drivePhraseId",
                table: "DrivePhrases");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "departmentManagerId",
                table: "DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "creativityPhraseId",
                table: "CreativityPhrases");

            migrationBuilder.DropColumn(
                name: "cooperationPhraseId",
                table: "CooperationPhrases");

            migrationBuilder.DropColumn(
                name: "messageId",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "communicationPhraseId",
                table: "CommunicationPhrases");

            migrationBuilder.DropColumn(
                name: "logId",
                table: "ActivityLogs");

            migrationBuilder.DropColumn(
                name: "acheivementPhraseId",
                table: "AcheivementPhrases");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Tasks",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PunctualityPhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Projects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProjectRoles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProjectManagers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PerformanceEvaluations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Milestones",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DrivePhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Departments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DepartmentManagers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CreativityPhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CooperationPhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ContactForms",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CommunicationPhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ActivityLogs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AcheivementPhrases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PunctualityPhrases",
                table: "PunctualityPhrases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectManagers",
                table: "ProjectManagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformanceEvaluations",
                table: "PerformanceEvaluations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrivePhrases",
                table: "DrivePhrases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreativityPhrases",
                table: "CreativityPhrases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooperationPhrases",
                table: "CooperationPhrases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactForms",
                table: "ContactForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationPhrases",
                table: "CommunicationPhrases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivityLogs",
                table: "ActivityLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcheivementPhrases",
                table: "AcheivementPhrases",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FaqViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faqTitle = table.Column<string>(nullable: true),
                    faqDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqViewModel", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentManagers_Employees_employeeId",
                table: "DepartmentManagers",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_DepartmentManagers_departmentManagerId",
                table: "Departments",
                column: "departmentManagerId",
                principalTable: "DepartmentManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_Employees_employeeId",
                table: "EmployeeProjectAttendances",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_Projects_projectId",
                table: "EmployeeProjectAttendances",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_ProjectRoles_roleId",
                table: "EmployeeProjectAttendances",
                column: "roleId",
                principalTable: "ProjectRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskRatings_Employees_employeeId",
                table: "EmployeeTaskRatings",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskRatings_Tasks_taskId",
                table: "EmployeeTaskRatings",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Tasks_taskId",
                table: "Milestones",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_AcheivementPhrases_acheivementPhraseId",
                table: "PerformanceEvaluations",
                column: "acheivementPhraseId",
                principalTable: "AcheivementPhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CommunicationPhrases_communicationPhraseId",
                table: "PerformanceEvaluations",
                column: "communicationPhraseId",
                principalTable: "CommunicationPhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CooperationPhrases_cooperationPhraseId",
                table: "PerformanceEvaluations",
                column: "cooperationPhraseId",
                principalTable: "CooperationPhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CreativityPhrases_creativityPhraseId",
                table: "PerformanceEvaluations",
                column: "creativityPhraseId",
                principalTable: "CreativityPhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_DepartmentManagers_departmentManagerId",
                table: "PerformanceEvaluations",
                column: "departmentManagerId",
                principalTable: "DepartmentManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_DrivePhrases_drivePhraseId",
                table: "PerformanceEvaluations",
                column: "drivePhraseId",
                principalTable: "DrivePhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_Employees_employeeId",
                table: "PerformanceEvaluations",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_PunctualityPhrases_punctualityPhraseId",
                table: "PerformanceEvaluations",
                column: "punctualityPhraseId",
                principalTable: "PunctualityPhrases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectManagers_Employees_employeeId",
                table: "ProjectManagers",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_departmentId",
                table: "Projects",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectManagers_projectManagerId",
                table: "Projects",
                column: "projectManagerId",
                principalTable: "ProjectManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Employees_employeeId",
                table: "Tasks",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_projectId",
                table: "Tasks",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentManagers_Employees_employeeId",
                table: "DepartmentManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_DepartmentManagers_departmentManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_Employees_employeeId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_Projects_projectId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProjectAttendances_ProjectRoles_roleId",
                table: "EmployeeProjectAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskRatings_Employees_employeeId",
                table: "EmployeeTaskRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskRatings_Tasks_taskId",
                table: "EmployeeTaskRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Tasks_taskId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_AcheivementPhrases_acheivementPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CommunicationPhrases_communicationPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CooperationPhrases_cooperationPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_CreativityPhrases_creativityPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_DepartmentManagers_departmentManagerId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_DrivePhrases_drivePhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_Employees_employeeId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceEvaluations_PunctualityPhrases_punctualityPhraseId",
                table: "PerformanceEvaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagers_Employees_employeeId",
                table: "ProjectManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_departmentId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectManagers_projectManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_employeeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_projectId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "FaqViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PunctualityPhrases",
                table: "PunctualityPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectManagers",
                table: "ProjectManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformanceEvaluations",
                table: "PerformanceEvaluations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrivePhrases",
                table: "DrivePhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreativityPhrases",
                table: "CreativityPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CooperationPhrases",
                table: "CooperationPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactForms",
                table: "ContactForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationPhrases",
                table: "CommunicationPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivityLogs",
                table: "ActivityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcheivementPhrases",
                table: "AcheivementPhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PunctualityPhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProjectRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProjectManagers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PerformanceEvaluations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Milestones");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DrivePhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CreativityPhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CooperationPhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CommunicationPhrases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ActivityLogs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AcheivementPhrases");

            migrationBuilder.AddColumn<int>(
                name: "taskId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "punctualityPhraseId",
                table: "PunctualityPhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "projectId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "ProjectRoles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "projectManagerId",
                table: "ProjectManagers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "evaluationId",
                table: "PerformanceEvaluations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "milestoneId",
                table: "Milestones",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "employeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "drivePhraseId",
                table: "DrivePhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "departmentManagerId",
                table: "DepartmentManagers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "creativityPhraseId",
                table: "CreativityPhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "cooperationPhraseId",
                table: "CooperationPhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "messageId",
                table: "ContactForms",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "communicationPhraseId",
                table: "CommunicationPhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "logId",
                table: "ActivityLogs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "acheivementPhraseId",
                table: "AcheivementPhrases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "taskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PunctualityPhrases",
                table: "PunctualityPhrases",
                column: "punctualityPhraseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "projectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles",
                column: "roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectManagers",
                table: "ProjectManagers",
                column: "projectManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformanceEvaluations",
                table: "PerformanceEvaluations",
                column: "evaluationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Milestones",
                table: "Milestones",
                column: "milestoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "employeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrivePhrases",
                table: "DrivePhrases",
                column: "drivePhraseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "departmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers",
                column: "departmentManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreativityPhrases",
                table: "CreativityPhrases",
                column: "creativityPhraseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CooperationPhrases",
                table: "CooperationPhrases",
                column: "cooperationPhraseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactForms",
                table: "ContactForms",
                column: "messageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationPhrases",
                table: "CommunicationPhrases",
                column: "communicationPhraseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivityLogs",
                table: "ActivityLogs",
                column: "logId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcheivementPhrases",
                table: "AcheivementPhrases",
                column: "acheivementPhraseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentManagers_Employees_employeeId",
                table: "DepartmentManagers",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_DepartmentManagers_departmentManagerId",
                table: "Departments",
                column: "departmentManagerId",
                principalTable: "DepartmentManagers",
                principalColumn: "departmentManagerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_Employees_employeeId",
                table: "EmployeeProjectAttendances",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_Projects_projectId",
                table: "EmployeeProjectAttendances",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "projectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjectAttendances_ProjectRoles_roleId",
                table: "EmployeeProjectAttendances",
                column: "roleId",
                principalTable: "ProjectRoles",
                principalColumn: "roleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskRatings_Employees_employeeId",
                table: "EmployeeTaskRatings",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskRatings_Tasks_taskId",
                table: "EmployeeTaskRatings",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "taskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Tasks_taskId",
                table: "Milestones",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "taskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_AcheivementPhrases_acheivementPhraseId",
                table: "PerformanceEvaluations",
                column: "acheivementPhraseId",
                principalTable: "AcheivementPhrases",
                principalColumn: "acheivementPhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CommunicationPhrases_communicationPhraseId",
                table: "PerformanceEvaluations",
                column: "communicationPhraseId",
                principalTable: "CommunicationPhrases",
                principalColumn: "communicationPhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CooperationPhrases_cooperationPhraseId",
                table: "PerformanceEvaluations",
                column: "cooperationPhraseId",
                principalTable: "CooperationPhrases",
                principalColumn: "cooperationPhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_CreativityPhrases_creativityPhraseId",
                table: "PerformanceEvaluations",
                column: "creativityPhraseId",
                principalTable: "CreativityPhrases",
                principalColumn: "creativityPhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_DepartmentManagers_departmentManagerId",
                table: "PerformanceEvaluations",
                column: "departmentManagerId",
                principalTable: "DepartmentManagers",
                principalColumn: "departmentManagerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_DrivePhrases_drivePhraseId",
                table: "PerformanceEvaluations",
                column: "drivePhraseId",
                principalTable: "DrivePhrases",
                principalColumn: "drivePhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_Employees_employeeId",
                table: "PerformanceEvaluations",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceEvaluations_PunctualityPhrases_punctualityPhraseId",
                table: "PerformanceEvaluations",
                column: "punctualityPhraseId",
                principalTable: "PunctualityPhrases",
                principalColumn: "punctualityPhraseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectManagers_Employees_employeeId",
                table: "ProjectManagers",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_departmentId",
                table: "Projects",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectManagers_projectManagerId",
                table: "Projects",
                column: "projectManagerId",
                principalTable: "ProjectManagers",
                principalColumn: "projectManagerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Employees_employeeId",
                table: "Tasks",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "employeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_projectId",
                table: "Tasks",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "projectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

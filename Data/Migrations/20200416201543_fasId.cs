using Microsoft.EntityFrameworkCore.Migrations;

namespace epeacweb.Data.Migrations
{
    public partial class fasId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Faqs",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "faqId",
                table: "Faqs");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Faqs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faqs",
                table: "Faqs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Faqs",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Faqs");

            migrationBuilder.AddColumn<int>(
                name: "faqId",
                table: "Faqs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faqs",
                table: "Faqs",
                column: "faqId");
        }
    }
}

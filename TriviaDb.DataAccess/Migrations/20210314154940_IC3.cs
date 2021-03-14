using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaDb.DataAccess.Migrations
{
    public partial class IC3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageId",
                table: "QuestionAnswers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageId",
                table: "QuestionAnswers");
        }
    }
}

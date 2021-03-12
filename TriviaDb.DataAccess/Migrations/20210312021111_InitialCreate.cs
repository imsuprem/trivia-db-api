using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TriviaDb.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    category = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    difficulty = table.Column<string>(type: "text", nullable: true),
                    question = table.Column<string>(type: "text", nullable: true),
                    correct_answer = table.Column<string>(type: "text", nullable: true),
                    incorrect_answers_string = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 9, "General Knowledge" },
                    { 32, "Entertainment: Cartoon & Animations" },
                    { 31, "Entertainment: Japanese Anime & Manga" },
                    { 30, "Science: Gadgets" },
                    { 29, "Entertainment: Comics" },
                    { 28, "Vehicles" },
                    { 27, "Animals" },
                    { 26, "Celebrities" },
                    { 24, "Politics" },
                    { 23, "History" },
                    { 22, "Geography" },
                    { 21, "Sports" },
                    { 25, "Art" },
                    { 19, "Science: Mathematics" },
                    { 10, "Entertainment: Books" },
                    { 20, "Mythology" },
                    { 12, "Entertainment: Music" },
                    { 13, "Entertainment: Musicals & Theatres" },
                    { 14, "Entertainment: Television" },
                    { 11, "Entertainment: Film" },
                    { 16, "Entertainment: Board Games" },
                    { 17, "Science & Nature" },
                    { 18, "Science: Computers" },
                    { 15, "Entertainment: Video Games" }
                });

            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "id", "category", "correct_answer", "difficulty", "incorrect_answers_string", "question", "type" },
                values: new object[,]
                {
                    { -1990943068, "History", "False", "easy", "True", "The United States of America was the first country to launch a man into space.", "boolean" },
                    { -1231208221, "Entertainment: Video Games", "False", "medium", "True", "Super Mario Bros. was released in 1990.", "boolean" },
                    { -827286599, "History", "False", "hard", "True", "The Kingdom of Prussia briefly held land in Estonia.", "boolean" },
                    { 1274290027, "History", "False", "medium", "True", "Sargon II, a king of the Neo-Assyrian Empire, was a direct descendant of Sargon of Akkad.", "boolean" },
                    { 1866955121, "Science: Computers", "False", "medium", "True", "MacOS is based on Linux.", "boolean" },
                    { -27360051, "Entertainment: Video Games", "True", "medium", "False", "TF2: The Medic will be credited for an assist if he heals a Spy that successfully saps a building.", "boolean" },
                    { -1698007983, "Science: Gadgets", "True", "easy", "False", "Microphones can be used not only to pick up sound, but also to project sound similar to a speaker.", "boolean" },
                    { -1993100696, "Entertainment: Japanese Anime & Manga", "False", "easy", "True", "In the &quot;To Love-Ru&quot; series, Golden Darkness is sent to kill Lala Deviluke.", "boolean" },
                    { 252581283, "General Knowledge", "True", "easy", "False", "Slovakia is a member of European Union-", "boolean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "QuestionAnswers");
        }
    }
}

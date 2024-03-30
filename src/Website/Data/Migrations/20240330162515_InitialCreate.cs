using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Credits = table.Column<int>(type: "INTEGER", nullable: false),
                    IsFinished = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationGroups",
                columns: table => new
                {
                    EvaluationGroupId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsGroupPassRequired = table.Column<bool>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationGroups", x => x.EvaluationGroupId);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationItems",
                columns: table => new
                {
                    EvaluationItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    PossibleMarks = table.Column<int>(type: "INTEGER", nullable: true),
                    EarnedMarks = table.Column<int>(type: "INTEGER", nullable: true),
                    EvaluationGroupId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationItems", x => x.EvaluationItemId);
                    table.ForeignKey(
                        name: "FK_EvaluationItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluationItems_EvaluationGroups_EvaluationGroupId",
                        column: x => x.EvaluationGroupId,
                        principalTable: "EvaluationGroups",
                        principalColumn: "EvaluationGroupId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationItems_CourseId",
                table: "EvaluationItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationItems_EvaluationGroupId",
                table: "EvaluationItems",
                column: "EvaluationGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationItems");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "EvaluationGroups");
        }
    }
}

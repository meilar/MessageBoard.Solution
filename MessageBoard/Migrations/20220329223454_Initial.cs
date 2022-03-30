using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Body = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Author", "Body" },
                values: new object[,]
                {
                    { 1, "Sam Murk", "A blog post about the challenges of working outside the box, and creating something unique" },
                    { 2, "Matthew Elderberry", "The most extra ordinary blog you've ever come across" },
                    { 3, "Tim Roth", "As borring as it gets. You do not want to read this!" },
                    { 4, "Jane Pickered", "If I was a fruit I would ne a mango" },
                    { 5, "Victoria fincert", "Please trust yourself. No one knows you better than yourself" },
                    { 6, "Jossi Brown", "Life is too short for what if's" },
                    { 7, "Mel Gibson", "this is a test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}

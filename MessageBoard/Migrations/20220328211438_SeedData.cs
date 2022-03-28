using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Author", "Body" },
                values: new object[,]
                {
                    { 1, "Sam Murk", "A blog post about the challenges of working outside the box, and creating something unique" },
                    { 2, "Matthew Elderberry", "The most extra ordinary blog you've ever come across" },
                    { 3, "Tim Roth", "As borring as it gets. You do not want to read this!" },
                    { 4, "Jane Pickered", "If I was a fruit I would ne a mango" },
                    { 5, "Victoria fincert", "Please trust yourself. No one knows you better than yourself" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);
        }
    }
}

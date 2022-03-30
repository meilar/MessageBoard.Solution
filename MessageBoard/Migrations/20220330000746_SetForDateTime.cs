using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class SetForDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 79, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                column: "DatePublished",
                value: new DateTime(2022, 3, 29, 17, 7, 46, 80, DateTimeKind.Local).AddTicks(3520));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Messages");
        }
    }
}

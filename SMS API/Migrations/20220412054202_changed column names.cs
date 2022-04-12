using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS_API.Migrations
{
    public partial class changedcolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Messages",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "Receiver",
                table: "Messages",
                newName: "OriginatorId");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Messages",
                newName: "Msisdn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Messages",
                newName: "Sender");

            migrationBuilder.RenameColumn(
                name: "OriginatorId",
                table: "Messages",
                newName: "Receiver");

            migrationBuilder.RenameColumn(
                name: "Msisdn",
                table: "Messages",
                newName: "Message");
        }
    }
}

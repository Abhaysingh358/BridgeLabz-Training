using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundooNotesApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddIsNotifiedToReminder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "Reminders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotified",
                table: "Reminders");
        }
    }
}

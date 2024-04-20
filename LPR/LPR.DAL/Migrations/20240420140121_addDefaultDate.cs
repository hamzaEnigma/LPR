using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LPR.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addDefaultDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Profesionnals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "HourAvailability",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "DateAvailabilities",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Profesionnals");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "HourAvailability");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "DateAvailabilities");
        }
    }
}

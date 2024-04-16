using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LPR.DAL.Migrations
{
    /// <inheritdoc />
    public partial class firstProfessional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionnals",
                columns: table => new
                {
                    pro_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pro_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pro_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionnals", x => x.pro_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionnals");
        }
    }
}

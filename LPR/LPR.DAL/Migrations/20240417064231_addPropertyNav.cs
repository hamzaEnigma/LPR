using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LPR.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addPropertyNav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HourAvailability",
                columns: table => new
                {
                    hou_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hou_Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hou_fk_Date = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourAvailability", x => x.hou_Id);
                    table.ForeignKey(
                        name: "FK_HourAvailability_DateAvailabilities_hou_fk_Date",
                        column: x => x.hou_fk_Date,
                        principalTable: "DateAvailabilities",
                        principalColumn: "dat_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HourAvailability_hou_fk_Date",
                table: "HourAvailability",
                column: "hou_fk_Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourAvailability");
        }
    }
}

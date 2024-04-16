using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LPR.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateAvailabilities",
                columns: table => new
                {
                    dat_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dat_Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dat_RealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_fk_Profesionnal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateAvailabilities", x => x.dat_Id);
                    table.ForeignKey(
                        name: "FK_DateAvailabilities_Profesionnals_dat_fk_Profesionnal",
                        column: x => x.dat_fk_Profesionnal,
                        principalTable: "Profesionnals",
                        principalColumn: "pro_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateAvailabilities_dat_fk_Profesionnal",
                table: "DateAvailabilities",
                column: "dat_fk_Profesionnal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateAvailabilities");
        }
    }
}

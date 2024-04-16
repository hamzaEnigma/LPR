using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LPR.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DateAvailabilities_Profesionnals_dat_fk_Profesionnal",
                table: "DateAvailabilities");

            migrationBuilder.AlterColumn<Guid>(
                name: "dat_fk_Profesionnal",
                table: "DateAvailabilities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DateAvailabilities_Profesionnals_dat_fk_Profesionnal",
                table: "DateAvailabilities",
                column: "dat_fk_Profesionnal",
                principalTable: "Profesionnals",
                principalColumn: "pro_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DateAvailabilities_Profesionnals_dat_fk_Profesionnal",
                table: "DateAvailabilities");

            migrationBuilder.AlterColumn<Guid>(
                name: "dat_fk_Profesionnal",
                table: "DateAvailabilities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_DateAvailabilities_Profesionnals_dat_fk_Profesionnal",
                table: "DateAvailabilities",
                column: "dat_fk_Profesionnal",
                principalTable: "Profesionnals",
                principalColumn: "pro_Id");
        }
    }
}

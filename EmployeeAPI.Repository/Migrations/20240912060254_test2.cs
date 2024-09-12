using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI.Repository.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attedences_Employees_EmployeeId",
                table: "Attedences");

            migrationBuilder.DropIndex(
                name: "IX_Attedences_EmployeeId",
                table: "Attedences");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Attedences",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Attedences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attedences_EmployeeId1",
                table: "Attedences",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attedences_Employees_EmployeeId1",
                table: "Attedences",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attedences_Employees_EmployeeId1",
                table: "Attedences");

            migrationBuilder.DropIndex(
                name: "IX_Attedences_EmployeeId1",
                table: "Attedences");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Attedences");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Attedences",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Attedences_EmployeeId",
                table: "Attedences",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attedences_Employees_EmployeeId",
                table: "Attedences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

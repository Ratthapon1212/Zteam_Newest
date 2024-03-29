using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zteam.Migrations
{
    /// <inheritdoc />
    public partial class Cartmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Duties",
                table: "Duties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Duties",
                newName: "Duty");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Game",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Duty",
                table: "Duty",
                column: "DutyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "DeveloperId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Duty",
                table: "Duty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Duty",
                newName: "Duties");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Game",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Duties",
                table: "Duties",
                column: "DutyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Developer_DeveloperId",
                table: "Game",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "DeveloperId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

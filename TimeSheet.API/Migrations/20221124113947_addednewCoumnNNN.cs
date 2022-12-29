using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeSheets.API.Migrations
{
    public partial class addednewCoumnNNN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProjectName",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Flag",
                table: "ProjectName",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ProjectName",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Flag",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProjectName");

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "ProjectName");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ProjectName");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Activities");
        }
    }
}

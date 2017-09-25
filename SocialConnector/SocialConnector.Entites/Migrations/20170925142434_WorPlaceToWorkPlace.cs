using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class WorPlaceToWorkPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorPlace",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "WorkPlace",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkPlace",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "WorPlace",
                table: "Users",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class StartupData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Genders", new string[] { "Id", "Title" }, new object[] { 1, "Male" });
            migrationBuilder.InsertData("Genders", new string[] { "Id", "Title" }, new object[] { 2, "Female" });

            migrationBuilder.InsertData("Roles", new string[] { "Id", "RoleTitle" }, new object[] { 1, "User" });
            migrationBuilder.InsertData("Roles", new string[] { "Id", "RoleTitle" }, new object[] { 2, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Genders", new string[] { "Id", "Title" }, new object[] { 1, "Male" });
            migrationBuilder.DeleteData("Genders", new string[] { "Id", "Title" }, new object[] { 2, "Female" });

            migrationBuilder.DeleteData("Roles", new string[] { "Id", "RoleTitle" }, new object[] { 1, "User" });
            migrationBuilder.DeleteData("Roles", new string[] { "Id", "RoleTitle" }, new object[] { 2, "Admin" });
        }
    }
}

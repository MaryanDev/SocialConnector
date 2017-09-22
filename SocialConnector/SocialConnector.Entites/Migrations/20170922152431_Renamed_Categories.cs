using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Renamed_Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Catrgories_CategoryId",
                table: "Interests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catrgories",
                table: "Catrgories");

            migrationBuilder.RenameTable(
                name: "Catrgories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Categories_CategoryId",
                table: "Interests",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Categories_CategoryId",
                table: "Interests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catrgories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catrgories",
                table: "Catrgories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Catrgories_CategoryId",
                table: "Interests",
                column: "CategoryId",
                principalTable: "Catrgories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

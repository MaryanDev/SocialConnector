using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class InterestsToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Users_UserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Interests_InterestId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InterestId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Interests_UserId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Interests");

            migrationBuilder.CreateTable(
                name: "InterestsToUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InterestId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsToUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterestsToUsers_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterestsToUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestsToUsers_InterestId",
                table: "InterestsToUsers",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestsToUsers_UserId",
                table: "InterestsToUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestsToUsers");

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Interests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InterestId",
                table: "Users",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_UserId",
                table: "Interests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Users_UserId",
                table: "Interests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Interests_InterestId",
                table: "Users",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

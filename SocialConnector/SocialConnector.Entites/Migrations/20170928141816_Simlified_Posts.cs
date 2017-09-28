using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Simlified_Posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostsToUser");

            migrationBuilder.DropTable(
                name: "PotsToGroup");

            migrationBuilder.AddColumn<int>(
                name: "ToGroupId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ToGroupId",
                table: "Posts",
                column: "ToGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ToUserId",
                table: "Posts",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Groups_ToGroupId",
                table: "Posts",
                column: "ToGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_ToUserId",
                table: "Posts",
                column: "ToUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Groups_ToGroupId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_ToUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ToGroupId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ToUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ToGroupId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ToUserId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "PostsToUser",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostsToUser", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_PostsToUser_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostsToUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PotsToGroup",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotsToGroup", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_PotsToGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PotsToGroup_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostsToUser_UserId",
                table: "PostsToUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PotsToGroup_GroupId",
                table: "PotsToGroup",
                column: "GroupId");
        }
    }
}

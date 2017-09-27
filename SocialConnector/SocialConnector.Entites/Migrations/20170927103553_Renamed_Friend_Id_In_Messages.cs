using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Renamed_Friend_Id_In_Messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_FrienId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_FrienId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_UserId_FrienId",
                table: "Relationships");

            migrationBuilder.DropColumn(
                name: "FrienId",
                table: "Relationships");

            migrationBuilder.AddColumn<int>(
                name: "FriendId",
                table: "Relationships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_FriendId",
                table: "Relationships",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_UserId_FriendId",
                table: "Relationships",
                columns: new[] { "UserId", "FriendId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships",
                column: "FriendId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_FriendId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_UserId_FriendId",
                table: "Relationships");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Relationships");

            migrationBuilder.AddColumn<int>(
                name: "FrienId",
                table: "Relationships",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_FrienId",
                table: "Relationships",
                column: "FrienId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_UserId_FrienId",
                table: "Relationships",
                columns: new[] { "UserId", "FrienId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FrienId",
                table: "Relationships",
                column: "FrienId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

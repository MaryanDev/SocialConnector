using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Unique_Indexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_FriendId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_UserId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Relationships");

            migrationBuilder.AddColumn<int>(
                name: "FrienId",
                table: "Relationships",
                type: "int",
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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUserId_ToUserId_SendDate",
                table: "Messages",
                columns: new[] { "FromUserId", "ToUserId", "SendDate" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FrienId",
                table: "Relationships",
                column: "FrienId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUserId_ToUserId_SendDate",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FrienId",
                table: "Relationships");

            migrationBuilder.AddColumn<int>(
                name: "FriendId",
                table: "Relationships",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_FriendId",
                table: "Relationships",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_UserId",
                table: "Relationships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUserId",
                table: "Messages",
                column: "FromUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships",
                column: "FriendId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

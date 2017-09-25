using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Removed_AdditionalUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_AdditionalUserInfo_AdditionalUserInfoUserId",
                table: "Interests");

            migrationBuilder.DropTable(
                name: "AdditionalUserInfo");

            migrationBuilder.DropIndex(
                name: "IX_Interests_AdditionalUserInfoUserId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "AdditionalUserInfoUserId",
                table: "Interests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdditionalUserInfoUserId",
                table: "Interests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdditionalUserInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    NationalityId = table.Column<int>(nullable: true),
                    PlaceOfBirth = table.Column<string>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    WorPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalUserInfo", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AdditionalUserInfo_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalUserInfo_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalUserInfo_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_AdditionalUserInfoUserId",
                table: "Interests",
                column: "AdditionalUserInfoUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalUserInfo_NationalityId",
                table: "AdditionalUserInfo",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalUserInfo_ReligionId",
                table: "AdditionalUserInfo",
                column: "ReligionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_AdditionalUserInfo_AdditionalUserInfoUserId",
                table: "Interests",
                column: "AdditionalUserInfoUserId",
                principalTable: "AdditionalUserInfo",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

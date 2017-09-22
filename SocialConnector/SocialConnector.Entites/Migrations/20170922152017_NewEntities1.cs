using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class NewEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditinalUserInfo_Nationality_NationalityId",
                table: "AdditinalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditinalUserInfo_Religion_ReligionId",
                table: "AdditinalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditinalUserInfo_Users_UserId",
                table: "AdditinalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_Category_CategoryId",
                table: "Interest");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_AdditinalUserInfo_UserId",
                table: "Interest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Religion",
                table: "Religion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interest",
                table: "Interest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditinalUserInfo",
                table: "AdditinalUserInfo");

            migrationBuilder.RenameTable(
                name: "Religion",
                newName: "Religions");

            migrationBuilder.RenameTable(
                name: "Nationality",
                newName: "Nationalities");

            migrationBuilder.RenameTable(
                name: "Interest",
                newName: "Interests");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Catrgories");

            migrationBuilder.RenameTable(
                name: "AdditinalUserInfo",
                newName: "UserInfo");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_UserId",
                table: "Interests",
                newName: "IX_Interests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_CategoryId",
                table: "Interests",
                newName: "IX_Interests_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditinalUserInfo_ReligionId",
                table: "UserInfo",
                newName: "IX_UserInfo_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditinalUserInfo_NationalityId",
                table: "UserInfo",
                newName: "IX_UserInfo_NationalityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Religions",
                table: "Religions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationalities",
                table: "Nationalities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interests",
                table: "Interests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catrgories",
                table: "Catrgories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_UserImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserImages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_UserId",
                table: "UserImages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Catrgories_CategoryId",
                table: "Interests",
                column: "CategoryId",
                principalTable: "Catrgories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_UserInfo_UserId",
                table: "Interests",
                column: "UserId",
                principalTable: "UserInfo",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Nationalities_NationalityId",
                table: "UserInfo",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Religions_ReligionId",
                table: "UserInfo",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Users_UserId",
                table: "UserInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Catrgories_CategoryId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_UserInfo_UserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Nationalities_NationalityId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Religions_ReligionId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Users_UserId",
                table: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Religions",
                table: "Religions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationalities",
                table: "Nationalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interests",
                table: "Interests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catrgories",
                table: "Catrgories");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "AdditinalUserInfo");

            migrationBuilder.RenameTable(
                name: "Religions",
                newName: "Religion");

            migrationBuilder.RenameTable(
                name: "Nationalities",
                newName: "Nationality");

            migrationBuilder.RenameTable(
                name: "Interests",
                newName: "Interest");

            migrationBuilder.RenameTable(
                name: "Catrgories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_ReligionId",
                table: "AdditinalUserInfo",
                newName: "IX_AdditinalUserInfo_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_NationalityId",
                table: "AdditinalUserInfo",
                newName: "IX_AdditinalUserInfo_NationalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_UserId",
                table: "Interest",
                newName: "IX_Interest_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_CategoryId",
                table: "Interest",
                newName: "IX_Interest_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditinalUserInfo",
                table: "AdditinalUserInfo",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Religion",
                table: "Religion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interest",
                table: "Interest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditinalUserInfo_Nationality_NationalityId",
                table: "AdditinalUserInfo",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditinalUserInfo_Religion_ReligionId",
                table: "AdditinalUserInfo",
                column: "ReligionId",
                principalTable: "Religion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditinalUserInfo_Users_UserId",
                table: "AdditinalUserInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_Category_CategoryId",
                table: "Interest",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_AdditinalUserInfo_UserId",
                table: "Interest",
                column: "UserId",
                principalTable: "AdditinalUserInfo",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SocialConnector.Entites.Migrations
{
    public partial class Required_Attributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupImages_Groups_GroupId",
                table: "GroupImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_OwnerId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_UserInfo_UserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AuthorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PotsToGroup_Groups_GroupId",
                table: "PotsToGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_UserId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserImages_Users_UserId",
                table: "UserImages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Nationalities_NationalityId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Religions_ReligionId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Users_UserId",
                table: "UserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersToGroups_Groups_GroupId",
                table: "UsersToGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersToGroups_Users_UserId",
                table: "UsersToGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "AdditionalUserInfo");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_ReligionId",
                table: "AdditionalUserInfo",
                newName: "IX_AdditionalUserInfo_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_NationalityId",
                table: "AdditionalUserInfo",
                newName: "IX_AdditionalUserInfo_NationalityId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UsersToGroups",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "UsersToGroups",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorPlace",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Relationships",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FriendId",
                table: "Relationships",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "PotsToGroup",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ToUserId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FromUserId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalUserInfoUserId",
                table: "Interests",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Groups",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "GroupImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalUserInfo",
                table: "AdditionalUserInfo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_InterestId",
                table: "Users",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalityId",
                table: "Users",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReligionId",
                table: "Users",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_AdditionalUserInfoUserId",
                table: "Interests",
                column: "AdditionalUserInfoUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalUserInfo_Nationalities_NationalityId",
                table: "AdditionalUserInfo",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalUserInfo_Religions_ReligionId",
                table: "AdditionalUserInfo",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalUserInfo_Users_UserId",
                table: "AdditionalUserInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupImages_Groups_GroupId",
                table: "GroupImages",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_OwnerId",
                table: "Groups",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_AdditionalUserInfo_AdditionalUserInfoUserId",
                table: "Interests",
                column: "AdditionalUserInfoUserId",
                principalTable: "AdditionalUserInfo",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Users_UserId",
                table: "Interests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromUserId",
                table: "Messages",
                column: "FromUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToUserId",
                table: "Messages",
                column: "ToUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PotsToGroup_Groups_GroupId",
                table: "PotsToGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships",
                column: "FriendId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_UserId",
                table: "Relationships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserImages_Users_UserId",
                table: "UserImages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Interests_InterestId",
                table: "Users",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Nationalities_NationalityId",
                table: "Users",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Religions_ReligionId",
                table: "Users",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersToGroups_Groups_GroupId",
                table: "UsersToGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersToGroups_Users_UserId",
                table: "UsersToGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalUserInfo_Nationalities_NationalityId",
                table: "AdditionalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalUserInfo_Religions_ReligionId",
                table: "AdditionalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalUserInfo_Users_UserId",
                table: "AdditionalUserInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupImages_Groups_GroupId",
                table: "GroupImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_OwnerId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_AdditionalUserInfo_AdditionalUserInfoUserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Users_UserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AuthorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PotsToGroup_Groups_GroupId",
                table: "PotsToGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_UserId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserImages_Users_UserId",
                table: "UserImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Interests_InterestId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Nationalities_NationalityId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Religions_ReligionId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersToGroups_Groups_GroupId",
                table: "UsersToGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersToGroups_Users_UserId",
                table: "UsersToGroups");

            migrationBuilder.DropIndex(
                name: "IX_Users_InterestId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NationalityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ReligionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Interests_AdditionalUserInfoUserId",
                table: "Interests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalUserInfo",
                table: "AdditionalUserInfo");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorPlace",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdditionalUserInfoUserId",
                table: "Interests");

            migrationBuilder.RenameTable(
                name: "AdditionalUserInfo",
                newName: "UserInfo");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalUserInfo_ReligionId",
                table: "UserInfo",
                newName: "IX_UserInfo_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalUserInfo_NationalityId",
                table: "UserInfo",
                newName: "IX_UserInfo_NationalityId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UsersToGroups",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "UsersToGroups",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserImages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Relationships",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FriendId",
                table: "Relationships",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "PotsToGroup",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ToUserId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FromUserId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "GroupImages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AuthorId",
                table: "Events",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupImages_Groups_GroupId",
                table: "GroupImages",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_OwnerId",
                table: "Groups",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_UserInfo_UserId",
                table: "Interests",
                column: "UserId",
                principalTable: "UserInfo",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromUserId",
                table: "Messages",
                column: "FromUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToUserId",
                table: "Messages",
                column: "ToUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PotsToGroup_Groups_GroupId",
                table: "PotsToGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_FriendId",
                table: "Relationships",
                column: "FriendId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_UserId",
                table: "Relationships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserImages_Users_UserId",
                table: "UserImages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Nationalities_NationalityId",
                table: "UserInfo",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Religions_ReligionId",
                table: "UserInfo",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Users_UserId",
                table: "UserInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersToGroups_Groups_GroupId",
                table: "UsersToGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersToGroups_Users_UserId",
                table: "UsersToGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

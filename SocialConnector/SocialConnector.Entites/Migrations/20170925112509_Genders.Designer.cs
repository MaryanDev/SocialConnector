﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SocialConnector.Entites.EF_DbContext;
using System;

namespace SocialConnector.Entites.Migrations
{
    [DbContext(typeof(SocialConnectorDbContext))]
    [Migration("20170925112509_Genders")]
    partial class Genders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SocialConnector.Entites.Entities.AdditionalUserInfo", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("NationalityId");

                    b.Property<string>("PlaceOfBirth");

                    b.Property<int>("ReligionId");

                    b.Property<string>("WorPlace");

                    b.HasKey("UserId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("ReligionId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("PostId");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateStarted");

                    b.Property<string>("Description");

                    b.Property<int>("Image");

                    b.Property<int>("ImageId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("OwnerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.GroupImage", b =>
                {
                    b.Property<int>("ImageId");

                    b.Property<int>("GroupId");

                    b.HasKey("ImageId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupImages");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromId");

                    b.Property<DateTime>("SendDate");

                    b.Property<string>("Text");

                    b.Property<int>("ToId");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("ImageId");

                    b.Property<DateTime>("PublishedDate");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ImageId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.PostsToGroup", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<int>("GroupId");

                    b.HasKey("PostId");

                    b.HasIndex("GroupId");

                    b.ToTable("PotsToGroup");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.PostToUser", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<int>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostsToUser");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfConfirmation");

                    b.Property<int>("FriendId");

                    b.Property<bool>("IsConfirmed");

                    b.Property<DateTime>("SendDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleTitle");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<DateTime?>("DateStarted");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("GenderId");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.UserImage", b =>
                {
                    b.Property<int>("ImageId");

                    b.Property<int>("UserId");

                    b.HasKey("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.UsersToGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsContact");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersToGroups");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.AdditionalUserInfo", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Nationality", "Nationality")
                        .WithMany("Users")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Religion", "Religion")
                        .WithMany("Users")
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithOne("UserDetails")
                        .HasForeignKey("SocialConnector.Entites.Entities.AdditionalUserInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Comment", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Event", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Group", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Owner")
                        .WithMany("GroupsInOwn")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.GroupImage", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Group", "Group")
                        .WithMany("GroupImages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Image", "Image")
                        .WithOne("GroupImage")
                        .HasForeignKey("SocialConnector.Entites.Entities.GroupImage", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Interest", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Category", "Category")
                        .WithMany("Interests")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.AdditionalUserInfo", "User")
                        .WithMany("Interests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Message", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Post", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany("PostsByUser")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.PostsToGroup", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Group", "Group")
                        .WithMany("PostsToGroup")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Post", "Post")
                        .WithOne("PostToGroup")
                        .HasForeignKey("SocialConnector.Entites.Entities.PostsToGroup", "PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.PostToUser", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Post", "Post")
                        .WithOne("PostToUser")
                        .HasForeignKey("SocialConnector.Entites.Entities.PostToUser", "PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany("PostsToUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Relationship", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Friend")
                        .WithMany()
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.User", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.UserImage", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Image", "Image")
                        .WithOne("UserImage")
                        .HasForeignKey("SocialConnector.Entites.Entities.UserImage", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.UsersToGroups", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Group", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

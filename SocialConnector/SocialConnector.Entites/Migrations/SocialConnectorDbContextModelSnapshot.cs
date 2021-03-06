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
    partial class SocialConnectorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("ImageId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

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

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("OwnerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupId");

                    b.Property<string>("Path");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.InterestsToUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InterestId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("UserId");

                    b.ToTable("InterestsToUsers");
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromUserId");

                    b.Property<DateTime>("SendDate");

                    b.Property<string>("Text");

                    b.Property<int>("ToUserId");

                    b.HasKey("Id");

                    b.HasIndex("ToUserId");

                    b.HasIndex("FromUserId", "ToUserId", "SendDate")
                        .IsUnique();

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

                    b.Property<int?>("ImageId");

                    b.Property<DateTime>("PublishedDate");

                    b.Property<string>("Text");

                    b.Property<int?>("ToGroupId");

                    b.Property<int?>("ToUserId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ImageId");

                    b.HasIndex("ToGroupId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Posts");
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

                    b.HasIndex("UserId", "FriendId")
                        .IsUnique();

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

                    b.Property<string>("Avatar");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<DateTime?>("DateStarted");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("GenderId");

                    b.Property<string>("LastName");

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Password");

                    b.Property<string>("PlaceOfBirth");

                    b.Property<int?>("ReligionId");

                    b.Property<int>("RoleId");

                    b.Property<string>("UserName");

                    b.Property<string>("WorkPlace");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
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

            modelBuilder.Entity("SocialConnector.Entites.Entities.Comment", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Event", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Group", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Owner")
                        .WithMany("GroupsInOwn")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Image", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Group", "Group")
                        .WithMany("Images")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany("Images")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Interest", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Category", "Category")
                        .WithMany("Interests")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.InterestsToUsers", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Interest", "Interest")
                        .WithMany("Users")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany("Interests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Message", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Post", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Group", "ToGroup")
                        .WithMany("Posts")
                        .HasForeignKey("ToGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.Relationship", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.User", "Friend")
                        .WithMany()
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.User", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Nationality", "Nationality")
                        .WithMany("Users")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Religion", "Religion")
                        .WithMany("Users")
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SocialConnector.Entites.Entities.UsersToGroups", b =>
                {
                    b.HasOne("SocialConnector.Entites.Entities.Group", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialConnector.Entites.Entities.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

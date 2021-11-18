﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211118202434_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp1.Entities.ApplicationRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Friend", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApplicationUserId")
                        .HasColumnType("bigint");

                    b.Property<long>("InviteByFk")
                        .HasColumnName("InviteByFk")
                        .HasColumnType("bigint");

                    b.Property<byte>("InviteStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InviteStatus")
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<long>("InviteToFk")
                        .HasColumnName("InviteToFk")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("InviteByFk");

                    b.HasIndex("InviteToFk");

                    b.ToTable("Friend","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(100);

                    b.Property<long>("CreatorFk")
                        .HasColumnName("CreatorFk")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<string>("GeographicalLocation")
                        .IsRequired()
                        .HasColumnName("GeographicalLocation")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAccepted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsAccepted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<decimal>("Latitude")
                        .HasColumnName("Latitude")
                        .HasColumnType("decimal(20,10)");

                    b.Property<decimal>("Longitude")
                        .HasColumnName("Longitude")
                        .HasColumnType("decimal(20,10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnName("Note")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<decimal>("ReviewScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReviewScore")
                        .HasColumnType("decimal(9,2)")
                        .HasDefaultValue(0m);

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatorFk");

                    b.ToTable("Location","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreatedOn")
                        .HasColumnType("smalldatetime")
                        .HasDefaultValue(new DateTime(2021, 11, 18, 20, 24, 33, 815, DateTimeKind.Utc).AddTicks(8160));

                    b.Property<long>("LocationFk")
                        .HasColumnName("LocationFk")
                        .HasColumnType("bigint");

                    b.Property<long?>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationComment","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("smalldatetime");

                    b.Property<long>("CreatorFk")
                        .HasColumnName("CreatorFk")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<bool>("IsPrivate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsPrivate")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("LocationFk")
                        .HasColumnName("Longitude")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnName("Note")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<DateTime>("StartsOn")
                        .HasColumnName("StartsOn")
                        .HasColumnType("smalldatetime");

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatorFk");

                    b.HasIndex("LocationFk");

                    b.ToTable("LocationEvent","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventGoing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LocationEventFk")
                        .HasColumnName("LocationEventFk")
                        .HasColumnType("bigint");

                    b.Property<byte>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Status")
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationEventFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationEventGoing","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventOrganizer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LocationEventFk")
                        .HasColumnName("LocationEventFk")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationEventFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationEventOrganizer","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventReview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EventFk")
                        .HasColumnName("EventFk")
                        .HasColumnType("bigint");

                    b.Property<byte>("Rating")
                        .HasColumnName("Rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("Text")
                        .HasColumnName("Text")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EventFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationEventReview","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationFavourite", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LocationFk")
                        .HasColumnName("LocationFk")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationFavourite","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationPicture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("smalldatetime");

                    b.Property<long>("LocationFk")
                        .HasColumnName("LocationFk")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("Url")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationPicture","dbo");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationReview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LocationFk")
                        .HasColumnName("LocationFk")
                        .HasColumnType("bigint");

                    b.Property<byte>("Rating")
                        .HasColumnName("Rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("Text")
                        .HasColumnName("Text")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(4000);

                    b.Property<Guid>("Uid")
                        .HasColumnName("Uid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserFk")
                        .HasColumnName("UserFk")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationFk");

                    b.HasIndex("UserFk");

                    b.ToTable("LocationReview","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Friend", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", null)
                        .WithMany("Friends")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "Inviter")
                        .WithMany()
                        .HasForeignKey("InviteByFk")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "Invetee")
                        .WithMany()
                        .HasForeignKey("InviteToFk")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Location", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "Creator")
                        .WithMany("CreatedLocations")
                        .HasForeignKey("CreatorFk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationComment", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Location", "Location")
                        .WithMany("LocationComments")
                        .HasForeignKey("LocationId");

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("LocationComments")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEvent", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("CreatorEvents")
                        .HasForeignKey("CreatorFk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.Location", "Location")
                        .WithMany("LocationEvents")
                        .HasForeignKey("LocationFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventGoing", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.LocationEvent", "LocationEvent")
                        .WithMany("UsersGoing")
                        .HasForeignKey("LocationEventFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "User")
                        .WithMany("GoingToEvents")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventOrganizer", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.LocationEvent", "LocationEvent")
                        .WithMany("Organizers")
                        .HasForeignKey("LocationEventFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "User")
                        .WithMany("OrganizerEvents")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationEventReview", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.LocationEvent", "LocationEvent")
                        .WithMany("Reviews")
                        .HasForeignKey("EventFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("LocationEventReviews")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationFavourite", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "User")
                        .WithMany("FavouriteLocations")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationPicture", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Location", "Location")
                        .WithMany("LocationPictures")
                        .HasForeignKey("LocationFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Pictures")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.LocationReview", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Location", "Location")
                        .WithMany("LocationReviews")
                        .HasForeignKey("LocationFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("LocationReviews")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

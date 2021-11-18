using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friend",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InviteToFk = table.Column<long>(type: "bigint", nullable: false),
                    InviteByFk = table.Column<long>(type: "bigint", nullable: false),
                    InviteStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0),
                    ApplicationUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friend_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friend_AspNetUsers_InviteByFk",
                        column: x => x.InviteByFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Friend_AspNetUsers_InviteToFk",
                        column: x => x.InviteToFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: true),
                    GeographicalLocation = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Note = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: false),
                    CreatorFk = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(20,10)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReviewScore = table.Column<decimal>(type: "decimal(9,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_AspNetUsers_CreatorFk",
                        column: x => x.CreatorFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationComment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: false),
                    LocationFk = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2021, 11, 18, 20, 24, 33, 815, DateTimeKind.Utc).AddTicks(8160)),
                    LocationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationComment_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationComment_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationEvent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: true),
                    Note = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: false),
                    CreatorFk = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    StartsOn = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Longitude = table.Column<long>(type: "bigint", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationEvent_AspNetUsers_CreatorFk",
                        column: x => x.CreatorFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationEvent_Location_Longitude",
                        column: x => x.Longitude,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationFavourite",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    LocationFk = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationFavourite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationFavourite_Location_LocationFk",
                        column: x => x.LocationFk,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationFavourite_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationPicture",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: false),
                    LocationFk = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationPicture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationPicture_Location_LocationFk",
                        column: x => x.LocationFk,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationPicture_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationReview",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: true),
                    LocationFk = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationReview_Location_LocationFk",
                        column: x => x.LocationFk,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationReview_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationEventGoing",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    LocationEventFk = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationEventGoing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationEventGoing_LocationEvent_LocationEventFk",
                        column: x => x.LocationEventFk,
                        principalSchema: "dbo",
                        principalTable: "LocationEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationEventGoing_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationEventOrganizer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    LocationEventFk = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationEventOrganizer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationEventOrganizer_LocationEvent_LocationEventFk",
                        column: x => x.LocationEventFk,
                        principalSchema: "dbo",
                        principalTable: "LocationEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationEventOrganizer_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationEventReview",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFk = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: true),
                    EventFk = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationEventReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationEventReview_LocationEvent_EventFk",
                        column: x => x.EventFk,
                        principalSchema: "dbo",
                        principalTable: "LocationEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationEventReview_AspNetUsers_UserFk",
                        column: x => x.UserFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_ApplicationUserId",
                schema: "dbo",
                table: "Friend",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_InviteByFk",
                schema: "dbo",
                table: "Friend",
                column: "InviteByFk");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_InviteToFk",
                schema: "dbo",
                table: "Friend",
                column: "InviteToFk");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CreatorFk",
                schema: "dbo",
                table: "Location",
                column: "CreatorFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationComment_LocationId",
                schema: "dbo",
                table: "LocationComment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationComment_UserFk",
                schema: "dbo",
                table: "LocationComment",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEvent_CreatorFk",
                schema: "dbo",
                table: "LocationEvent",
                column: "CreatorFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEvent_Longitude",
                schema: "dbo",
                table: "LocationEvent",
                column: "Longitude");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventGoing_LocationEventFk",
                schema: "dbo",
                table: "LocationEventGoing",
                column: "LocationEventFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventGoing_UserFk",
                schema: "dbo",
                table: "LocationEventGoing",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventOrganizer_LocationEventFk",
                schema: "dbo",
                table: "LocationEventOrganizer",
                column: "LocationEventFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventOrganizer_UserFk",
                schema: "dbo",
                table: "LocationEventOrganizer",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventReview_EventFk",
                schema: "dbo",
                table: "LocationEventReview",
                column: "EventFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationEventReview_UserFk",
                schema: "dbo",
                table: "LocationEventReview",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationFavourite_LocationFk",
                schema: "dbo",
                table: "LocationFavourite",
                column: "LocationFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationFavourite_UserFk",
                schema: "dbo",
                table: "LocationFavourite",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationPicture_LocationFk",
                schema: "dbo",
                table: "LocationPicture",
                column: "LocationFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationPicture_UserFk",
                schema: "dbo",
                table: "LocationPicture",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationReview_LocationFk",
                schema: "dbo",
                table: "LocationReview",
                column: "LocationFk");

            migrationBuilder.CreateIndex(
                name: "IX_LocationReview_UserFk",
                schema: "dbo",
                table: "LocationReview",
                column: "UserFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Friend",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationComment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationEventGoing",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationEventOrganizer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationEventReview",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationFavourite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationPicture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocationReview",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LocationEvent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

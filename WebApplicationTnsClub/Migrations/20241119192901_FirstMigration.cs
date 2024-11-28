using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplicationTnsClub.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    logofile = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    link = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    isautorenewal = table.Column<bool>(type: "boolean", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "SheduleClubs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheduleClubs", x => x.id);
                    table.ForeignKey(
                        name: "FK_SheduleClubs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SheduleClubOpenBookings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SheduleClubId = table.Column<long>(type: "bigint", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state_booking = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheduleClubOpenBookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_SheduleClubOpenBookings_SheduleClubs_SheduleClubId",
                        column: x => x.SheduleClubId,
                        principalTable: "SheduleClubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<int>(type: "integer", nullable: true),
                    RateId = table.Column<long>(type: "bigint", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    NextId = table.Column<long>(type: "bigint", nullable: true),
                    date_of_sale = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserOfSaleId = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    TicketId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bookings_Bookings_NextId",
                        column: x => x.NextId,
                        principalTable: "Bookings",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Bookings_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Bookings_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    OrganizatorId = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_Groups_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rates_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Rates_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    login = table.Column<string>(type: "text", nullable: true),
                    avatarfile = table.Column<string>(type: "text", nullable: true),
                    firstname = table.Column<string>(type: "text", nullable: true),
                    secondname = table.Column<string>(type: "text", nullable: true),
                    lastname = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    BookingId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Shedules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    typeofday = table.Column<int>(type: "integer", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<int>(type: "integer", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    RateId = table.Column<long>(type: "bigint", nullable: true),
                    SheduleClubId = table.Column<long>(type: "bigint", nullable: true),
                    TicketId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedules", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shedules_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Shedules_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "Rates",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Shedules_SheduleClubs_SheduleClubId",
                        column: x => x.SheduleClubId,
                        principalTable: "SheduleClubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Shedules_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    text = table.Column<string>(type: "text", nullable: true),
                    link = table.Column<string>(type: "text", nullable: true),
                    imagefile = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    AuthorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.id);
                    table.ForeignKey(
                        name: "FK_News_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_News_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonalConnects",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MentorId = table.Column<string>(type: "text", nullable: true),
                    HeirId = table.Column<string>(type: "text", nullable: true),
                    type_connect = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalConnects", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonalConnects_Users_HeirId",
                        column: x => x.HeirId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonalConnects_Users_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ClubId",
                table: "Bookings",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_NextId",
                table: "Bookings",
                column: "NextId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RateId",
                table: "Bookings",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TicketId",
                table: "Bookings",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserOfSaleId",
                table: "Bookings",
                column: "UserOfSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ClubId",
                table: "Groups",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_OrganizatorId",
                table: "Groups",
                column: "OrganizatorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_ClubId",
                table: "News",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalConnects_HeirId",
                table: "PersonalConnects",
                column: "HeirId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalConnects_MentorId",
                table: "PersonalConnects",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ClubId",
                table: "Rates",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_GroupId",
                table: "Rates",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SheduleClubOpenBookings_SheduleClubId",
                table: "SheduleClubOpenBookings",
                column: "SheduleClubId");

            migrationBuilder.CreateIndex(
                name: "IX_SheduleClubs_ClubId",
                table: "SheduleClubs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_GroupId",
                table: "Shedules",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_RateId",
                table: "Shedules",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_SheduleClubId",
                table: "Shedules",
                column: "SheduleClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_TicketId",
                table: "Shedules",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BookingId",
                table: "Users",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rates_RateId",
                table: "Bookings",
                column: "RateId",
                principalTable: "Rates",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserOfSaleId",
                table: "Bookings",
                column: "UserOfSaleId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_OrganizatorId",
                table: "Groups",
                column: "OrganizatorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AspNetUsers_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Clubs_ClubId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Clubs_ClubId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Clubs_ClubId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rates_RateId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Tickets_TicketId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserOfSaleId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_OrganizatorId",
                table: "Groups");

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
                name: "News");

            migrationBuilder.DropTable(
                name: "PersonalConnects");

            migrationBuilder.DropTable(
                name: "SheduleClubOpenBookings");

            migrationBuilder.DropTable(
                name: "Shedules");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SheduleClubs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}

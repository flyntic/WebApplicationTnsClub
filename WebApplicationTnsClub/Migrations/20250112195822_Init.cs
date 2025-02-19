using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplicationTnsClub.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    comment = table.Column<string>(type: "text", nullable: true),
                    logofile = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    link = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualAbonements",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    datebegin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateend = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lengthdays = table.Column<int>(type: "integer", nullable: false),
                    lengthstr = table.Column<string>(type: "text", nullable: false),
                    countofsession = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualAbonements", x => x.id);
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
                name: "Prices",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.id);
                    table.ForeignKey(
                        name: "FK_Prices_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
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
                    comment = table.Column<string>(type: "text", nullable: true),
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
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
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
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    visit = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bookings_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Coachs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coachs", x => x.id);
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
                    comment = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    CoachId = table.Column<long>(type: "bigint", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_Groups_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "IndividualAbonementsOfPlayers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    AbonementId = table.Column<long>(type: "bigint", nullable: true),
                    CoachId = table.Column<long>(type: "bigint", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    isautorenewal = table.Column<bool>(type: "boolean", nullable: true),
                    visits = table.Column<DateTime?[]>(type: "timestamp with time zone[]", nullable: false),
                    skips = table.Column<DateTime?[]>(type: "timestamp with time zone[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualAbonementsOfPlayers", x => x.id);
                    table.ForeignKey(
                        name: "FK_IndividualAbonementsOfPlayers_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_IndividualAbonementsOfPlayers_IndividualAbonements_Abonemen~",
                        column: x => x.AbonementId,
                        principalTable: "IndividualAbonements",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GroupClubs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClubs", x => x.id);
                    table.ForeignKey(
                        name: "FK_GroupClubs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GroupClubs_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    typeofday = table.Column<int>(type: "integer", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<int>(type: "integer", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    IndividualAbonementId = table.Column<long>(type: "bigint", nullable: true),
                    PriceSessionsId = table.Column<long>(type: "bigint", nullable: true),
                    SheduleClubId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sessions_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Sessions_IndividualAbonements_IndividualAbonementId",
                        column: x => x.IndividualAbonementId,
                        principalTable: "IndividualAbonements",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Sessions_Prices_PriceSessionsId",
                        column: x => x.PriceSessionsId,
                        principalTable: "Prices",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Sessions_SheduleClubs_SheduleClubId",
                        column: x => x.SheduleClubId,
                        principalTable: "SheduleClubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GroupAbonements",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    GroupClubId = table.Column<long>(type: "bigint", nullable: true),
                    datebegin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateend = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lengthdays = table.Column<int>(type: "integer", nullable: false),
                    lengthstr = table.Column<string>(type: "text", nullable: false),
                    countofsession = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAbonements", x => x.id);
                    table.ForeignKey(
                        name: "FK_GroupAbonements_GroupClubs_GroupClubId",
                        column: x => x.GroupClubId,
                        principalTable: "GroupClubs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GroupAbonementsOfPalyers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    AbonementId = table.Column<long>(type: "bigint", nullable: true),
                    PlayerId = table.Column<long>(type: "bigint", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    isautorenewal = table.Column<bool>(type: "boolean", nullable: true),
                    visits = table.Column<DateTime?[]>(type: "timestamp with time zone[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAbonementsOfPalyers", x => x.id);
                    table.ForeignKey(
                        name: "FK_GroupAbonementsOfPalyers_GroupAbonements_AbonementId",
                        column: x => x.AbonementId,
                        principalTable: "GroupAbonements",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClubId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Managers_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
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
                    comment = table.Column<string>(type: "text", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datecreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    datedelete = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    IndividualAbonementOfPlayerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.id);
                    table.ForeignKey(
                        name: "FK_Players_IndividualAbonementsOfPlayers_IndividualAbonementOf~",
                        column: x => x.IndividualAbonementOfPlayerId,
                        principalTable: "IndividualAbonementsOfPlayers",
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
                    comment = table.Column<string>(type: "text", nullable: true),
                    avatarfile = table.Column<string>(type: "text", nullable: true),
                    firstname = table.Column<string>(type: "text", nullable: true),
                    secondname = table.Column<string>(type: "text", nullable: true),
                    lastname = table.Column<string>(type: "text", nullable: true),
                    CoachId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    PlayerId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_Users_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

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
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ClubId",
                table: "Bookings",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coachs_UserId",
                table: "Coachs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAbonements_GroupClubId",
                table: "GroupAbonements",
                column: "GroupClubId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAbonementsOfPalyers_AbonementId",
                table: "GroupAbonementsOfPalyers",
                column: "AbonementId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAbonementsOfPalyers_PlayerId",
                table: "GroupAbonementsOfPalyers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClubs_ClubId",
                table: "GroupClubs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClubs_GroupId",
                table: "GroupClubs",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CoachId",
                table: "Groups",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAbonementsOfPlayers_AbonementId",
                table: "IndividualAbonementsOfPlayers",
                column: "AbonementId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAbonementsOfPlayers_CoachId",
                table: "IndividualAbonementsOfPlayers",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_ClubId",
                table: "Managers",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_ClubId",
                table: "News",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_IndividualAbonementOfPlayerId",
                table: "Players",
                column: "IndividualAbonementOfPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ClubId",
                table: "Prices",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_GroupId",
                table: "Sessions",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_IndividualAbonementId",
                table: "Sessions",
                column: "IndividualAbonementId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_PriceSessionsId",
                table: "Sessions",
                column: "PriceSessionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SheduleClubId",
                table: "Sessions",
                column: "SheduleClubId");

            migrationBuilder.CreateIndex(
                name: "IX_SheduleClubs_ClubId",
                table: "SheduleClubs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoachId",
                table: "Users",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ParentId",
                table: "Users",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlayerId",
                table: "Users",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Users_UserId",
                table: "Authors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coachs_Users_UserId",
                table: "Coachs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupAbonementsOfPalyers_Players_PlayerId",
                table: "GroupAbonementsOfPalyers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Users_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Users_UserId",
                table: "Parents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coachs_Users_UserId",
                table: "Coachs");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Users_UserId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Admins");

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
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "GroupAbonementsOfPalyers");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GroupAbonements");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "SheduleClubs");

            migrationBuilder.DropTable(
                name: "GroupClubs");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "IndividualAbonementsOfPlayers");

            migrationBuilder.DropTable(
                name: "Coachs");

            migrationBuilder.DropTable(
                name: "IndividualAbonements");
        }
    }
}

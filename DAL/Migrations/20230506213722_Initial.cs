using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryTranslations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillTranslations_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityTranslations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredNumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    NumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Applications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePictures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "NULL"),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => new { x.UserId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_UserSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSkills",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSkills", x => new { x.ApplicationId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ApplicationSkills_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => new { x.UserId, x.ApplicationId });
                    table.ForeignKey(
                        name: "FK_Volunteers_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Volunteers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VolunteerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VolunteerApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VolunteerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Volunteers_VolunteerUserId_VolunteerApplicationId",
                        columns: x => new { x.VolunteerUserId, x.VolunteerApplicationId },
                        principalTable: "Volunteers",
                        principalColumns: new[] { "UserId", "ApplicationId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("07fa298d-0b6c-433f-815c-4f148525c65c"), "culture and art" },
                    { new Guid("5fc3eb59-9aba-475c-a3ad-e583154caa06"), "sports and physical culture" },
                    { new Guid("9c9c8972-3ac8-4fa9-aeb5-3d3ce6bd11f8"), "education" },
                    { new Guid("c6768455-bb50-4b5b-b248-1c1167e6c3d8"), "social programs" },
                    { new Guid("d7be699c-18ce-4e41-ab9f-7732b060a9ee"), "health care" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("15b3cca5-196e-41e9-a6fb-9a5804c2e9e1"), "pl" },
                    { new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("3094853b-4bc1-4cd8-afcd-6376410429d5"), "psychology" },
                    { new Guid("a71aae76-aeba-46a4-a38c-3b46b97dbb14"), "cooking" },
                    { new Guid("d144b8ea-dd6c-49c3-95f1-800e852ca73d"), "medicine" },
                    { new Guid("dc333177-ac18-4f98-a483-08abef3e3880"), "building" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "DescriptionCategory", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("86460e1f-44d6-4ab3-b8d1-3ddbfb76d56a"), new Guid("5fc3eb59-9aba-475c-a3ad-e583154caa06"), " ", "uk", "спорт та фізична культура" },
                    { new Guid("8fc6a070-61d3-4b6c-b7ea-a64025b27950"), new Guid("9c9c8972-3ac8-4fa9-aeb5-3d3ce6bd11f8"), " ", "en", "education" },
                    { new Guid("bcdfe4df-b9d0-4981-95bc-47d14c56bf20"), new Guid("c6768455-bb50-4b5b-b248-1c1167e6c3d8"), " ", "en", "social programs" },
                    { new Guid("d8a164d7-5bf6-4710-af73-0d5b811fbae8"), new Guid("9c9c8972-3ac8-4fa9-aeb5-3d3ce6bd11f8"), " ", "uk", "освіта" },
                    { new Guid("da3bf6b2-cd81-477f-bc31-d1bf75312b7f"), new Guid("c6768455-bb50-4b5b-b248-1c1167e6c3d8"), " ", "uk", "соціальні програми" },
                    { new Guid("f2eb423a-4742-432c-a5ea-76962eefb23e"), new Guid("5fc3eb59-9aba-475c-a3ad-e583154caa06"), " ", "en", "sport and physical culture" },
                    { new Guid("f87a2559-3239-4567-986f-aa28514c7ee8"), new Guid("d7be699c-18ce-4e41-ab9f-7732b060a9ee"), " ", "en", "health care" },
                    { new Guid("fa5ddb3c-a34d-4861-8643-53e87f57423b"), new Guid("07fa298d-0b6c-433f-815c-4f148525c65c"), " ", "en", "culture and art" },
                    { new Guid("fb147234-4938-419a-806b-72c399b30187"), new Guid("d7be699c-18ce-4e41-ab9f-7732b060a9ee"), " ", "uk", "охорона здоров'я" },
                    { new Guid("fd51d42e-47c6-4e7a-85f0-ba77f1362261"), new Guid("07fa298d-0b6c-433f-815c-4f148525c65c"), " ", "uk", "культура та мистецтво" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("0b1f946f-362e-434a-9778-4e8a8c3244ce"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "chv" },
                    { new Guid("0c7ed481-4d90-4166-8a78-6e312635dbad"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "kr" },
                    { new Guid("12929774-d650-456e-a20d-f07539ddfd6a"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "od" },
                    { new Guid("20765619-7a21-44b3-83d9-4fe743c13dd7"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "pol" },
                    { new Guid("37ebf0f8-7fbb-4d4e-95d9-1dab76d0751c"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "zhy" },
                    { new Guid("3a30b596-746e-4dd8-84a7-6dab2a2a4448"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "khar" },
                    { new Guid("40951dc8-987a-4b86-94c1-e92a9772d900"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "su" },
                    { new Guid("73f1e4fc-1bba-41aa-adaa-1d60c285470c"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "dn" },
                    { new Guid("7b290f79-2b1a-4a78-ab3e-7e762df427d5"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "zp" },
                    { new Guid("85183dbd-bc0e-450d-a7f6-adaa0c7e0af2"), new Guid("15b3cca5-196e-41e9-a6fb-9a5804c2e9e1"), "lub" },
                    { new Guid("88fbc4c6-c99f-4a9d-8cf6-b9a10cd05c51"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "if" },
                    { new Guid("8a266fff-3d36-46a6-96ff-4e078b8b9819"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "ky" },
                    { new Guid("8d159d5b-9d28-4bc3-afd7-c6129a217e6c"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "ter" },
                    { new Guid("9a768ec8-969b-40c8-a936-c305fc4f6c73"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "my" },
                    { new Guid("a20ad981-8c26-47f6-9b31-9aa8fa5dc1da"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "uzh" },
                    { new Guid("a3b55636-1c77-40a4-a221-fb5bf9f06c8e"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "chh" },
                    { new Guid("a44e975a-9113-47d0-984f-5077ba7ba51d"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "lut" },
                    { new Guid("c9b935d5-1ac1-4bca-85f7-16cd006cf4cc"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "chk" },
                    { new Guid("cc6f9095-4632-4aa9-aa39-c069f7640a4a"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "kher" },
                    { new Guid("d2d042f1-a0ea-45dc-89dc-0d3c657ce980"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "ri" },
                    { new Guid("d4ea89bf-a217-4f2a-a2d2-d8be16307249"), new Guid("15b3cca5-196e-41e9-a6fb-9a5804c2e9e1"), "var" },
                    { new Guid("d54f0393-6df4-4912-9b9c-89f793576bde"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "khm" },
                    { new Guid("e4ea9dd7-2564-4a0c-9553-3d938c3dad88"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "lv" },
                    { new Guid("f1af7f79-3f80-4d45-b199-a07d84ae618f"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "vi" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("141f53e5-eff1-42b4-bd8a-97000e74226c"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "uk", "Україна" },
                    { new Guid("39573a14-73dc-4ffe-b744-4a3873d7b491"), new Guid("15b3cca5-196e-41e9-a6fb-9a5804c2e9e1"), "uk", "Польша" },
                    { new Guid("a6ecd310-1e3a-4b28-978c-d8888d0c5515"), new Guid("15b3cca5-196e-41e9-a6fb-9a5804c2e9e1"), "en", "Poland" },
                    { new Guid("d452dd50-c209-48cd-96ed-81e8f3045132"), new Guid("ed92ebed-2a14-4657-a1fe-72bab737454d"), "en", "Ukraine" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("1392510f-8f0c-4dca-9f4b-1090e0dbed03"), "en", "medicine", new Guid("d144b8ea-dd6c-49c3-95f1-800e852ca73d") },
                    { new Guid("7d080f99-bd77-416f-8a33-6b3074360e9d"), "en", "cooking", new Guid("a71aae76-aeba-46a4-a38c-3b46b97dbb14") },
                    { new Guid("847155cb-3862-4bbf-af84-72f7c0e10cc3"), "en", "building", new Guid("dc333177-ac18-4f98-a483-08abef3e3880") },
                    { new Guid("a279e5a5-da2d-49bb-acb6-56835368d5c2"), "en", "psychology", new Guid("3094853b-4bc1-4cd8-afcd-6376410429d5") }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("b9929fd4-840b-42be-8252-468e5cb049cf"), "uk", "будівництво", new Guid("dc333177-ac18-4f98-a483-08abef3e3880") },
                    { new Guid("c0ecd3ae-2cf5-46d7-a85c-0bb3668aeb85"), "uk", "психологія", new Guid("3094853b-4bc1-4cd8-afcd-6376410429d5") },
                    { new Guid("d9c75948-9630-4235-9d1f-56a29a268555"), "uk", "кулінарія", new Guid("a71aae76-aeba-46a4-a38c-3b46b97dbb14") },
                    { new Guid("f7055ac4-0cf0-4f50-9ca7-7b76faccf7d8"), "uk", "медицина", new Guid("d144b8ea-dd6c-49c3-95f1-800e852ca73d") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("052d7243-3056-4e43-b7c7-edd5667fad83"), new Guid("8d159d5b-9d28-4bc3-afd7-c6129a217e6c"), "uk", "Тернопіль" },
                    { new Guid("16eccbae-1746-4be1-92ce-732bddc2d689"), new Guid("a44e975a-9113-47d0-984f-5077ba7ba51d"), "uk", "Луцьк" },
                    { new Guid("184fc500-351f-4df5-a505-4b51bd982c24"), new Guid("a20ad981-8c26-47f6-9b31-9aa8fa5dc1da"), "en", "Uzhhorod" },
                    { new Guid("21313f40-90e9-4189-9110-88ca335fc41c"), new Guid("a20ad981-8c26-47f6-9b31-9aa8fa5dc1da"), "uk", "Ужгород" },
                    { new Guid("21bfa2a5-4f8a-45ce-825b-2f730e0a4064"), new Guid("d4ea89bf-a217-4f2a-a2d2-d8be16307249"), "en", "Varshava" },
                    { new Guid("22ddd223-426d-494a-a19d-34d9021eae1a"), new Guid("40951dc8-987a-4b86-94c1-e92a9772d900"), "uk", "Суми" },
                    { new Guid("24c369e2-6f92-4503-8a68-0d010f1bb60c"), new Guid("88fbc4c6-c99f-4a9d-8cf6-b9a10cd05c51"), "uk", "Івано-Франківськ" },
                    { new Guid("26e3e255-87ce-47f1-8cf3-245ee8332686"), new Guid("cc6f9095-4632-4aa9-aa39-c069f7640a4a"), "uk", "Херсон" },
                    { new Guid("2c83c953-9de3-45d8-a058-d25a8b1da305"), new Guid("37ebf0f8-7fbb-4d4e-95d9-1dab76d0751c"), "en", "Zhytomyr" },
                    { new Guid("3347bea6-01d4-4515-925a-cf461c336d87"), new Guid("c9b935d5-1ac1-4bca-85f7-16cd006cf4cc"), "en", "Cherkasy" },
                    { new Guid("37679c94-fe5d-4a93-8110-8f19344fb735"), new Guid("f1af7f79-3f80-4d45-b199-a07d84ae618f"), "uk", "Вінниця" },
                    { new Guid("461f675c-9567-445f-925d-99a28f4323be"), new Guid("a3b55636-1c77-40a4-a221-fb5bf9f06c8e"), "en", "Chernihiv" },
                    { new Guid("4efe6393-3fd0-43ef-a026-763dd44754ea"), new Guid("d54f0393-6df4-4912-9b9c-89f793576bde"), "en", "Khmelnytskyi" },
                    { new Guid("51c842f9-8e52-4262-9e24-b5980603279d"), new Guid("e4ea9dd7-2564-4a0c-9553-3d938c3dad88"), "en", "Lviv" },
                    { new Guid("59d8414b-566b-4b65-8104-d4419bd55425"), new Guid("0c7ed481-4d90-4166-8a78-6e312635dbad"), "en", "Kropyvnytskyi" },
                    { new Guid("5c11b41c-2b1e-42db-9824-88d944834318"), new Guid("f1af7f79-3f80-4d45-b199-a07d84ae618f"), "en", "Vinnytsia" },
                    { new Guid("621b088f-b0f0-4eb6-9f15-02699f275f1c"), new Guid("85183dbd-bc0e-450d-a7f6-adaa0c7e0af2"), "uk", "Люблін" },
                    { new Guid("63441f7a-9ef8-4d18-9f5a-1bec57cdc001"), new Guid("a44e975a-9113-47d0-984f-5077ba7ba51d"), "en", "Lutsk" },
                    { new Guid("666e091d-108e-430c-a771-be64f9f92f03"), new Guid("8a266fff-3d36-46a6-96ff-4e078b8b9819"), "uk", "Київ" },
                    { new Guid("69b524e1-cbad-4a80-aa96-2bbac8e963a2"), new Guid("88fbc4c6-c99f-4a9d-8cf6-b9a10cd05c51"), "en", "Ivano-Frankivsk" },
                    { new Guid("6caa4c3c-366b-4ab6-ba2e-7757eb406327"), new Guid("0b1f946f-362e-434a-9778-4e8a8c3244ce"), "uk", "Чернівці" },
                    { new Guid("6d603610-7158-4888-8b82-7278e0f5b4d2"), new Guid("c9b935d5-1ac1-4bca-85f7-16cd006cf4cc"), "uk", "Черкаси" },
                    { new Guid("6e9e6524-ab4a-4709-9cd4-86288abf97b9"), new Guid("d4ea89bf-a217-4f2a-a2d2-d8be16307249"), "uk", "Варшава" },
                    { new Guid("71e4e0c2-ed59-4bcd-8ed2-9f0e6a77e077"), new Guid("a3b55636-1c77-40a4-a221-fb5bf9f06c8e"), "uk", "Чернігів" },
                    { new Guid("7b647580-621d-4cc6-8782-4b2ee72d959e"), new Guid("0c7ed481-4d90-4166-8a78-6e312635dbad"), "uk", "Кропивницький" },
                    { new Guid("7ccf4dbb-34c2-4202-abfd-ab83ef8d0a0d"), new Guid("12929774-d650-456e-a20d-f07539ddfd6a"), "en", "Odesa" },
                    { new Guid("7d864b69-d8ea-4adc-bf5b-deb19e95ea6f"), new Guid("9a768ec8-969b-40c8-a936-c305fc4f6c73"), "en", "Mykolaiv" },
                    { new Guid("7f767d9c-a721-49cc-ad38-bb9cf9599f61"), new Guid("12929774-d650-456e-a20d-f07539ddfd6a"), "uk", "Одеса" },
                    { new Guid("876b38ba-0df3-476c-bee4-3b8d76d7bb4c"), new Guid("3a30b596-746e-4dd8-84a7-6dab2a2a4448"), "uk", "Харків" },
                    { new Guid("8c04544b-6df1-4a03-8963-a88cb71c2fd7"), new Guid("37ebf0f8-7fbb-4d4e-95d9-1dab76d0751c"), "uk", "Житомир" },
                    { new Guid("8c776939-4a7a-4d6e-8612-2f549fd4584b"), new Guid("8a266fff-3d36-46a6-96ff-4e078b8b9819"), "en", "Kyiv" },
                    { new Guid("8ed027a7-da40-4f07-b7b4-47595f706038"), new Guid("20765619-7a21-44b3-83d9-4fe743c13dd7"), "en", "Poltava" },
                    { new Guid("936db2fa-d253-43f5-b655-66a01e9f93b9"), new Guid("3a30b596-746e-4dd8-84a7-6dab2a2a4448"), "en", "Kharkiv" },
                    { new Guid("976a7f4a-2923-473e-8d64-2cefbbee5e85"), new Guid("85183dbd-bc0e-450d-a7f6-adaa0c7e0af2"), "en", "Lublin" },
                    { new Guid("9ff49db5-6b6e-406b-a22f-c208e96e3445"), new Guid("40951dc8-987a-4b86-94c1-e92a9772d900"), "en", "Sumy" },
                    { new Guid("a1fcddb7-4609-494c-9ebd-ba7e53c8a12e"), new Guid("20765619-7a21-44b3-83d9-4fe743c13dd7"), "uk", "Полтава" },
                    { new Guid("ac3daffc-1d32-4c7f-8ef0-b4ba20d8fd82"), new Guid("cc6f9095-4632-4aa9-aa39-c069f7640a4a"), "en", "Kherson" },
                    { new Guid("adcdaef4-5ab0-4acd-b102-18c6f061de61"), new Guid("d2d042f1-a0ea-45dc-89dc-0d3c657ce980"), "en", "Rivne" },
                    { new Guid("b6fbe20d-11cb-4abf-8277-be22a1b9f362"), new Guid("7b290f79-2b1a-4a78-ab3e-7e762df427d5"), "uk", "Запоріжжя" },
                    { new Guid("ba717f19-89f7-43e3-99df-d911d8854365"), new Guid("0b1f946f-362e-434a-9778-4e8a8c3244ce"), "en", "Chernivtsi" },
                    { new Guid("bcc27c4a-2642-4ea6-bd21-3d46db1b4c1f"), new Guid("73f1e4fc-1bba-41aa-adaa-1d60c285470c"), "en", "Dnipro" },
                    { new Guid("c9c0540b-a8f2-4ca1-92cb-3927b9e38825"), new Guid("d2d042f1-a0ea-45dc-89dc-0d3c657ce980"), "uk", "Рівне" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("dce8bfd2-3497-4743-90ab-a251ee7b6e89"), new Guid("73f1e4fc-1bba-41aa-adaa-1d60c285470c"), "uk", "Дніпро" },
                    { new Guid("dd99c722-86f4-4db8-a4a4-b3a0a8a25414"), new Guid("d54f0393-6df4-4912-9b9c-89f793576bde"), "uk", "Хмельницький" },
                    { new Guid("e38bed56-30ce-4345-b150-f842cd7984aa"), new Guid("8d159d5b-9d28-4bc3-afd7-c6129a217e6c"), "en", "Ternopil" },
                    { new Guid("f1b4fb98-a5cb-4758-9dd6-6b0caa6b891c"), new Guid("7b290f79-2b1a-4a78-ab3e-7e762df427d5"), "en", "Zaporizhzhia" },
                    { new Guid("f430d668-4478-4500-bfcf-9751d108e0dd"), new Guid("9a768ec8-969b-40c8-a936-c305fc4f6c73"), "uk", "Миколаїв" },
                    { new Guid("f6c0ffe0-1f2b-4757-8014-e596d610dcda"), new Guid("e4ea9dd7-2564-4a0c-9553-3d938c3dad88"), "uk", "Львів" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("4a2d6582-ea27-4d4e-8055-bc8ce08dc519"), new Guid("f1af7f79-3f80-4d45-b199-a07d84ae618f"), new DateTime(2023, 5, 7, 0, 37, 20, 556, DateTimeKind.Local).AddTicks(1364), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CategoryId",
                table: "Applications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CityId",
                table: "Applications",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSkills_SkillId",
                table: "ApplicationSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CityTranslations_CityId",
                table: "CityTranslations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryTranslations_CountryId",
                table: "CountryTranslations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_VolunteerUserId_VolunteerApplicationId",
                table: "Messages",
                columns: new[] { "VolunteerUserId", "VolunteerApplicationId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePictures_UserId",
                table: "ProfilePictures",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillTranslations_SkillId",
                table: "SkillTranslations",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_ApplicationId",
                table: "Volunteers",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationSkills");

            migrationBuilder.DropTable(
                name: "CategoryTranslations");

            migrationBuilder.DropTable(
                name: "CityTranslations");

            migrationBuilder.DropTable(
                name: "CountryTranslations");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ProfilePictures");

            migrationBuilder.DropTable(
                name: "SkillTranslations");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

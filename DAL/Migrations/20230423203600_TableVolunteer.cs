using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class TableVolunteer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    RequiredNumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    NumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
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
                name: "Volunteers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "uk" },
                    { new Guid("8fd9a232-b434-46b7-a852-8e3b869e3f87"), "pl" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("1b2e9b19-cec2-43c1-9bbd-4caab9b440ae"), "cook" },
                    { new Guid("f1ba4263-a060-413b-b59f-3c64827f5c97"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("111e3eb2-18e4-4b55-a8f0-fb3450f38059"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "zhy" },
                    { new Guid("125334b7-3004-4199-8861-a4ff6742f88c"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "dn" },
                    { new Guid("167cef3f-8dd7-4007-8906-cdd153e39d25"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "pol" },
                    { new Guid("188a308f-43e8-4130-83f9-013e5d4ef666"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "khar" },
                    { new Guid("4f9ea7c9-ca7c-4e04-a269-e0ac38d07927"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "od" },
                    { new Guid("57c27557-9d99-451e-8699-47e5c469b04c"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "kher" },
                    { new Guid("642ce6c6-da4f-4ed3-bb77-1107f65f5a1e"), new Guid("8fd9a232-b434-46b7-a852-8e3b869e3f87"), "lub" },
                    { new Guid("64adddf0-f850-4dab-ad9d-2f387c939c94"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "khm" },
                    { new Guid("6a8c7284-e6cd-4b8a-ac93-24c01ec42448"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "if" },
                    { new Guid("7cd48e22-01f3-4cd4-8397-c91b61bef4de"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "lv" },
                    { new Guid("80dd7b10-32fe-4cb0-9209-43462c0b5ec7"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "ter" },
                    { new Guid("8c294b3b-7646-4b2d-a160-37a69d7879f9"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "chh" },
                    { new Guid("8dbcd7f4-7796-4b68-a6ef-2bcfa4e3d92c"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "kr" },
                    { new Guid("8eace09c-e5cd-482b-ac45-ce38c159ed9e"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "ri" },
                    { new Guid("90077437-ab7d-4567-acf1-1def1ecc1192"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "my" },
                    { new Guid("9eaf07f5-e4ce-43d0-81c4-39b5d83a0227"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "chv" },
                    { new Guid("a8a6d684-68a0-4873-aebf-fddfafe85063"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "ky" },
                    { new Guid("ae8117ef-3fad-4938-a735-260191db959b"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "chk" },
                    { new Guid("baaaf1e0-435e-4381-9584-e002824b74a5"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "su" },
                    { new Guid("bf3604f6-620a-415e-99c3-fe9b424187d8"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "lut" },
                    { new Guid("c426e9c7-efe9-4306-8dbc-82dd8cf606e7"), new Guid("8fd9a232-b434-46b7-a852-8e3b869e3f87"), "var" },
                    { new Guid("ce35730d-6273-48dc-83f0-801247b8a96c"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "zp" },
                    { new Guid("de33dcf8-277d-4e69-b895-ea86abb77ac1"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "vi" },
                    { new Guid("fe85c02e-2f2d-4ce8-b1ba-921345ed1080"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "uzh" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("661e84d5-7916-41a3-9ea5-7677d6058e17"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "en", "Ukraine" },
                    { new Guid("9e056ab7-1ee0-4cc2-a0d6-8ddfecb608dc"), new Guid("14cd0261-199c-4c17-81c0-a2e1abc3be0d"), "uk", "Україна" },
                    { new Guid("a8e4d7c8-e489-46bb-9430-40c32bc18369"), new Guid("8fd9a232-b434-46b7-a852-8e3b869e3f87"), "en", "Poland" },
                    { new Guid("d0102965-bbd8-4735-ab5a-b4146ae84fea"), new Guid("8fd9a232-b434-46b7-a852-8e3b869e3f87"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0ce32d45-f1ea-4c39-b73f-2a06972a3f27"), new Guid("4f9ea7c9-ca7c-4e04-a269-e0ac38d07927"), "en", "Odesa" },
                    { new Guid("0d5f566a-9bfc-43ec-8402-a973cb248ec7"), new Guid("90077437-ab7d-4567-acf1-1def1ecc1192"), "uk", "Миколаїв" },
                    { new Guid("0f056bd6-ec29-4da1-902b-e1d5c11505cf"), new Guid("8dbcd7f4-7796-4b68-a6ef-2bcfa4e3d92c"), "en", "Kropyvnytskyi" },
                    { new Guid("0fb31d7a-87f2-47c4-b8f6-3c2f2930a012"), new Guid("80dd7b10-32fe-4cb0-9209-43462c0b5ec7"), "uk", "Тернопіль" },
                    { new Guid("1430de26-7003-4bd6-b622-aed6e68c6bf6"), new Guid("6a8c7284-e6cd-4b8a-ac93-24c01ec42448"), "en", "Ivano-Frankivsk" },
                    { new Guid("2d888a2b-37fd-4ed5-96c1-d284fa1fcfd5"), new Guid("188a308f-43e8-4130-83f9-013e5d4ef666"), "uk", "Харків" },
                    { new Guid("2e3b84eb-5ac2-4f29-b160-7b8415ce61e0"), new Guid("167cef3f-8dd7-4007-8906-cdd153e39d25"), "en", "Poltava" },
                    { new Guid("2f0510de-c75a-4dec-a92c-77a6780ddc58"), new Guid("90077437-ab7d-4567-acf1-1def1ecc1192"), "en", "Mykolaiv" },
                    { new Guid("3cb3a2a5-b2f2-43eb-b054-a36707cc3837"), new Guid("8c294b3b-7646-4b2d-a160-37a69d7879f9"), "en", "Chernihiv" },
                    { new Guid("40e01046-192b-464f-8036-7314ba69c3ad"), new Guid("ae8117ef-3fad-4938-a735-260191db959b"), "uk", "Черкаси" },
                    { new Guid("48c92493-2e3a-416b-9e24-14375d07b57d"), new Guid("167cef3f-8dd7-4007-8906-cdd153e39d25"), "uk", "Полтава" },
                    { new Guid("4aa01796-e772-4c1e-82e6-fa34065b44cf"), new Guid("c426e9c7-efe9-4306-8dbc-82dd8cf606e7"), "en", "Varshava" },
                    { new Guid("4aae64a0-6690-4dd4-a68c-3c4237e7489e"), new Guid("bf3604f6-620a-415e-99c3-fe9b424187d8"), "en", "Lutsk" },
                    { new Guid("515e65f8-cb9c-4d7f-9c72-45f6c6d8fc77"), new Guid("642ce6c6-da4f-4ed3-bb77-1107f65f5a1e"), "uk", "Люблін" },
                    { new Guid("5ba2ce87-6077-40c7-9937-775266a1dd60"), new Guid("8c294b3b-7646-4b2d-a160-37a69d7879f9"), "uk", "Чернігів" },
                    { new Guid("5e5cb045-f916-4e54-ad24-09f692a1864f"), new Guid("a8a6d684-68a0-4873-aebf-fddfafe85063"), "en", "Kyiv" },
                    { new Guid("654dbb63-185e-4947-9ae7-3bcf376979f0"), new Guid("642ce6c6-da4f-4ed3-bb77-1107f65f5a1e"), "en", "Lublin" },
                    { new Guid("6f64ec4a-f02f-4098-b80d-a8e372ab98c5"), new Guid("80dd7b10-32fe-4cb0-9209-43462c0b5ec7"), "en", "Ternopil" },
                    { new Guid("77ff1dac-0a10-4228-b768-405d85a230ab"), new Guid("64adddf0-f850-4dab-ad9d-2f387c939c94"), "uk", "Хмельницький" },
                    { new Guid("7ab3a048-31d0-4785-993f-f0eead4a13c9"), new Guid("7cd48e22-01f3-4cd4-8397-c91b61bef4de"), "uk", "Львів" },
                    { new Guid("7df0b79c-24a4-40ba-90a9-b963bed125d0"), new Guid("c426e9c7-efe9-4306-8dbc-82dd8cf606e7"), "uk", "Варшава" },
                    { new Guid("81450f5c-e41d-4df7-b9e5-6b0cee1affb5"), new Guid("188a308f-43e8-4130-83f9-013e5d4ef666"), "en", "Kharkiv" },
                    { new Guid("86b5d89e-78b6-4193-b4a8-d31f285a34e3"), new Guid("baaaf1e0-435e-4381-9584-e002824b74a5"), "en", "Sumy" },
                    { new Guid("8c3076fb-04e8-4215-97e4-6d8a1f0b08e1"), new Guid("fe85c02e-2f2d-4ce8-b1ba-921345ed1080"), "uk", "Ужгород" },
                    { new Guid("93e970e4-d2c5-4ac7-9844-1d85bf77d482"), new Guid("9eaf07f5-e4ce-43d0-81c4-39b5d83a0227"), "uk", "Чернівці" },
                    { new Guid("941235c4-c784-4ee5-a549-107f424f0274"), new Guid("57c27557-9d99-451e-8699-47e5c469b04c"), "uk", "Херсон" },
                    { new Guid("a97d53db-62c7-4c78-b892-afc64316c404"), new Guid("fe85c02e-2f2d-4ce8-b1ba-921345ed1080"), "en", "Uzhhorod" },
                    { new Guid("a97ec0cf-5b90-474b-b03c-d7092fd0412f"), new Guid("a8a6d684-68a0-4873-aebf-fddfafe85063"), "uk", "Київ" },
                    { new Guid("aa96e768-f9a0-4b78-bdc2-63b7c0bda781"), new Guid("ae8117ef-3fad-4938-a735-260191db959b"), "en", "Cherkasy" },
                    { new Guid("b200bb8f-046e-45ec-9abc-8728dab9063f"), new Guid("ce35730d-6273-48dc-83f0-801247b8a96c"), "uk", "Запоріжжя" },
                    { new Guid("b52e67eb-f04d-4d59-bf21-a73fdf87d2be"), new Guid("125334b7-3004-4199-8861-a4ff6742f88c"), "uk", "Дніпро" },
                    { new Guid("b7c73312-6fd2-4109-904d-9edcfbf3c06c"), new Guid("de33dcf8-277d-4e69-b895-ea86abb77ac1"), "uk", "Вінниця" },
                    { new Guid("bf04c0a6-0084-4a39-bd4c-06fa83df3dd2"), new Guid("8dbcd7f4-7796-4b68-a6ef-2bcfa4e3d92c"), "uk", "Кропивницький" },
                    { new Guid("cff5fd84-8408-48ab-b4ee-43923ca86585"), new Guid("baaaf1e0-435e-4381-9584-e002824b74a5"), "uk", "Суми" },
                    { new Guid("d10ae331-e325-49ea-8ae6-875051dcef18"), new Guid("ce35730d-6273-48dc-83f0-801247b8a96c"), "en", "Zaporizhzhia" },
                    { new Guid("d678e82e-e848-4d45-b699-12c8c719f26f"), new Guid("de33dcf8-277d-4e69-b895-ea86abb77ac1"), "en", "Vinnytsia" },
                    { new Guid("d6de433a-ecdd-47ed-ac4a-8c2ef5835acb"), new Guid("8eace09c-e5cd-482b-ac45-ce38c159ed9e"), "uk", "Рівне" },
                    { new Guid("d7736349-9a24-4925-bee2-1e6ac938eb22"), new Guid("8eace09c-e5cd-482b-ac45-ce38c159ed9e"), "en", "Rivne" },
                    { new Guid("da9f8690-f02a-4ab2-a793-f4b99d44dadc"), new Guid("57c27557-9d99-451e-8699-47e5c469b04c"), "en", "Kherson" },
                    { new Guid("e044d294-97c7-4e07-8ab6-bf59cc6ebed7"), new Guid("4f9ea7c9-ca7c-4e04-a269-e0ac38d07927"), "uk", "Одеса" },
                    { new Guid("e0b43934-0453-4b55-add3-ae35e7b3ca63"), new Guid("125334b7-3004-4199-8861-a4ff6742f88c"), "en", "Dnipro" },
                    { new Guid("e492ec0f-2f2f-4cee-8c14-02ddd77aa59f"), new Guid("64adddf0-f850-4dab-ad9d-2f387c939c94"), "en", "Khmelnytskyi" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("e7b59d1e-4037-484a-b64f-c4eb82bf0f03"), new Guid("6a8c7284-e6cd-4b8a-ac93-24c01ec42448"), "uk", "Івано-Франківськ" },
                    { new Guid("ebf1746f-0798-4a9b-8081-0d0a1e9a75f7"), new Guid("9eaf07f5-e4ce-43d0-81c4-39b5d83a0227"), "en", "Chernivtsi" },
                    { new Guid("f2130334-6aac-45d0-bcfa-5d1fde843db1"), new Guid("7cd48e22-01f3-4cd4-8397-c91b61bef4de"), "en", "Lviv" },
                    { new Guid("f2aadff9-8185-4008-8c3b-d7d37ef947a2"), new Guid("111e3eb2-18e4-4b55-a8f0-fb3450f38059"), "en", "Zhytomyr" },
                    { new Guid("f62714c9-ab76-41fc-b25b-883d455b277f"), new Guid("111e3eb2-18e4-4b55-a8f0-fb3450f38059"), "uk", "Житомир" },
                    { new Guid("fa40fdb9-c000-4041-825e-e3b8048136c7"), new Guid("bf3604f6-620a-415e-99c3-fe9b424187d8"), "uk", "Луцьк" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("8615ffa0-068b-421c-8a1e-e3dc479158bf"), new Guid("de33dcf8-277d-4e69-b895-ea86abb77ac1"), new DateTime(2023, 4, 23, 23, 36, 0, 105, DateTimeKind.Local).AddTicks(1452), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

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
                name: "IX_ProfilePictures_UserId",
                table: "ProfilePictures",
                column: "UserId",
                unique: true);

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
                name: "CityTranslations");

            migrationBuilder.DropTable(
                name: "CountryTranslations");

            migrationBuilder.DropTable(
                name: "ProfilePictures");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

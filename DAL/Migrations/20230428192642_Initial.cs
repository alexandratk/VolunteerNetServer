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
                    VolunteerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VolunteerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VolunteerApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("5c19215f-fae7-4a65-a084-ccf7747cd124"), "pl" },
                    { new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0c08734b-8bed-460b-a173-d0dedc8f581e"), "building" },
                    { new Guid("1476a5d3-d28b-430c-8a1a-4762b075017a"), "psychology" },
                    { new Guid("3eaec87f-d6a6-4dfb-9217-db0493101836"), "cooking" },
                    { new Guid("518c2fb1-d3f5-428d-b6e4-ea5f15e6fb82"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("05a12e22-f5c3-4c69-a2b5-b65cd118c752"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "ter" },
                    { new Guid("0e0530ad-f180-47a8-811c-fadd0ac59251"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "dn" },
                    { new Guid("127e6bf5-9cb4-4219-aa99-85e678864ed5"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "kher" },
                    { new Guid("15ad2297-c9dc-4d29-97ce-7e668cbb1d38"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "khar" },
                    { new Guid("1963d595-2df5-4bf3-95e3-e50bf2151277"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "ky" },
                    { new Guid("21392d0c-2b1c-4f29-bb75-13cbeb445e47"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "chk" },
                    { new Guid("25777b82-798b-46ff-8e79-5d9eee60b090"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "zp" },
                    { new Guid("2a68db21-dcc1-4bd2-beb9-d1ba44468bd6"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "zhy" },
                    { new Guid("2d50b9de-cdc5-40b9-8ee2-1db6db29ecf6"), new Guid("5c19215f-fae7-4a65-a084-ccf7747cd124"), "lub" },
                    { new Guid("30e2cf2d-0d07-4da8-9d83-e6383ce63b73"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "chh" },
                    { new Guid("34700f20-3e77-4ad2-af01-c93c851dcdd7"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "my" },
                    { new Guid("4324eb80-49d0-4118-8e34-14f80f71f027"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "lv" },
                    { new Guid("56a792e5-7166-4269-a5d4-b5d9a0e3a960"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "pol" },
                    { new Guid("5eaa27aa-319b-4f2f-a068-f852531b80ad"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "su" },
                    { new Guid("71c6eec0-012b-4436-9e9f-882d00f83f16"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "chv" },
                    { new Guid("9a5b8e47-eeae-4ce5-8843-ada8b9eb8f8d"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "vi" },
                    { new Guid("a837f771-78d3-495d-bed6-ef9162d444ac"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "od" },
                    { new Guid("ad32f639-0a8a-4bef-ab88-53d45b8c2814"), new Guid("5c19215f-fae7-4a65-a084-ccf7747cd124"), "var" },
                    { new Guid("b2fbebf7-5c37-4a68-8869-b98cdfd34616"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "uzh" },
                    { new Guid("b9bbe674-e9a7-4464-86ff-df7e850bf7f1"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "lut" },
                    { new Guid("ca75b4ab-3fdb-4974-8f9e-382ec320654b"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "kr" },
                    { new Guid("dd2bda82-ff64-40e6-be42-51f79f53c05e"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "ri" },
                    { new Guid("e50cfd5c-f728-43c2-9474-5cc744295f29"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "if" },
                    { new Guid("eb734b8e-e223-4eb1-addf-7960dc06ddc4"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "khm" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("5bdec72c-564a-4c8a-87ce-b812b669ab84"), new Guid("5c19215f-fae7-4a65-a084-ccf7747cd124"), "en", "Poland" },
                    { new Guid("ca5c65ef-9d68-4c3e-9e7d-f4e5f1b7025c"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "uk", "Україна" },
                    { new Guid("d03374f5-52bc-47ef-bf20-7bb6cfd05f10"), new Guid("61c9af51-12ef-4da9-ae94-068f5d94922b"), "en", "Ukraine" },
                    { new Guid("d17aa06e-6f36-4aab-b094-99efaddfdd52"), new Guid("5c19215f-fae7-4a65-a084-ccf7747cd124"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("1547f492-c4bd-494e-89ca-a5047b93d1ad"), "en", "building", new Guid("0c08734b-8bed-460b-a173-d0dedc8f581e") },
                    { new Guid("2dfb5ef1-5274-42eb-b4c1-0d94de0dbf23"), "en", "cooking", new Guid("3eaec87f-d6a6-4dfb-9217-db0493101836") },
                    { new Guid("32249ff7-c7b4-4b28-81d2-e4ab930055cd"), "uk", "будівництво", new Guid("0c08734b-8bed-460b-a173-d0dedc8f581e") },
                    { new Guid("41df599d-4da2-4949-82dd-2bd219c5b672"), "en", "psychology", new Guid("1476a5d3-d28b-430c-8a1a-4762b075017a") },
                    { new Guid("782c1b79-2218-492a-bb8f-d5cfc32a9789"), "en", "medicine", new Guid("518c2fb1-d3f5-428d-b6e4-ea5f15e6fb82") },
                    { new Guid("90d07a71-d27d-4625-be63-28e90d5e185f"), "uk", "медицина", new Guid("518c2fb1-d3f5-428d-b6e4-ea5f15e6fb82") },
                    { new Guid("d5a84219-5f29-4d4e-ad02-63a4244719f3"), "uk", "психологія", new Guid("1476a5d3-d28b-430c-8a1a-4762b075017a") },
                    { new Guid("f2c77f2a-df56-403d-b425-36f38619d4fa"), "uk", "кулінарія", new Guid("3eaec87f-d6a6-4dfb-9217-db0493101836") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("05435a4c-f006-47c0-9ede-45600efb9c11"), new Guid("eb734b8e-e223-4eb1-addf-7960dc06ddc4"), "en", "Khmelnytskyi" },
                    { new Guid("08a1c873-a161-4cdb-b4b3-8b054e93f8c8"), new Guid("0e0530ad-f180-47a8-811c-fadd0ac59251"), "en", "Dnipro" },
                    { new Guid("09d167b2-786b-4a68-bab6-49601239855f"), new Guid("2a68db21-dcc1-4bd2-beb9-d1ba44468bd6"), "uk", "Житомир" },
                    { new Guid("0ff89b52-3b4d-43bf-9e35-7b28e697a9be"), new Guid("ca75b4ab-3fdb-4974-8f9e-382ec320654b"), "en", "Kropyvnytskyi" },
                    { new Guid("10188182-c6eb-465b-a7d3-6a89cf7e1a45"), new Guid("56a792e5-7166-4269-a5d4-b5d9a0e3a960"), "uk", "Полтава" },
                    { new Guid("126712ea-592d-496f-88c1-1d4f3e9ceffd"), new Guid("4324eb80-49d0-4118-8e34-14f80f71f027"), "en", "Lviv" },
                    { new Guid("131dab1f-a578-43f1-a182-efbf8a2a0ef8"), new Guid("30e2cf2d-0d07-4da8-9d83-e6383ce63b73"), "en", "Chernihiv" },
                    { new Guid("14950546-282f-453a-a2d3-15018b2b0e5c"), new Guid("5eaa27aa-319b-4f2f-a068-f852531b80ad"), "uk", "Суми" },
                    { new Guid("1df94653-13de-4286-b327-89371aa3baf3"), new Guid("a837f771-78d3-495d-bed6-ef9162d444ac"), "uk", "Одеса" },
                    { new Guid("353fb47a-373d-4d36-8134-c990c21442c8"), new Guid("b9bbe674-e9a7-4464-86ff-df7e850bf7f1"), "uk", "Луцьк" },
                    { new Guid("41964212-5257-4994-ac6f-c7cfd6f8c5f1"), new Guid("71c6eec0-012b-4436-9e9f-882d00f83f16"), "en", "Chernivtsi" },
                    { new Guid("4aa2af7c-f2e8-47fc-9d54-9810c9f19d1c"), new Guid("2d50b9de-cdc5-40b9-8ee2-1db6db29ecf6"), "en", "Lublin" },
                    { new Guid("4c902c82-4d71-4681-8776-948b41f672f7"), new Guid("9a5b8e47-eeae-4ce5-8843-ada8b9eb8f8d"), "uk", "Вінниця" },
                    { new Guid("4f1ca3d6-cdab-467e-a39a-1b5dd1e712a3"), new Guid("0e0530ad-f180-47a8-811c-fadd0ac59251"), "uk", "Дніпро" },
                    { new Guid("5187fae3-369d-4e3f-afef-9cc8a97a70e6"), new Guid("e50cfd5c-f728-43c2-9474-5cc744295f29"), "uk", "Івано-Франківськ" },
                    { new Guid("51aa6d3c-54c2-43f7-9fea-177c8b6573fa"), new Guid("15ad2297-c9dc-4d29-97ce-7e668cbb1d38"), "en", "Kharkiv" },
                    { new Guid("55fdda02-a16f-4b84-a2fb-c15af2d64996"), new Guid("30e2cf2d-0d07-4da8-9d83-e6383ce63b73"), "uk", "Чернігів" },
                    { new Guid("5a1fcf66-7b57-4e64-bd06-44542ed0a9eb"), new Guid("4324eb80-49d0-4118-8e34-14f80f71f027"), "uk", "Львів" },
                    { new Guid("5a21504b-4097-41cc-a476-99759d8c187b"), new Guid("1963d595-2df5-4bf3-95e3-e50bf2151277"), "en", "Kyiv" },
                    { new Guid("5ae4c8a2-2918-48e5-bd21-fa7aedfb39b6"), new Guid("ca75b4ab-3fdb-4974-8f9e-382ec320654b"), "uk", "Кропивницький" },
                    { new Guid("68a927da-1180-40ca-bc73-28a237c0245c"), new Guid("b2fbebf7-5c37-4a68-8869-b98cdfd34616"), "uk", "Ужгород" },
                    { new Guid("6dc08f1c-42e5-42a1-80c8-0523af7082db"), new Guid("9a5b8e47-eeae-4ce5-8843-ada8b9eb8f8d"), "en", "Vinnytsia" },
                    { new Guid("729c660c-2ddc-4756-ad5c-c71be04f511e"), new Guid("b2fbebf7-5c37-4a68-8869-b98cdfd34616"), "en", "Uzhhorod" },
                    { new Guid("753667c9-6121-4866-9c40-2b92e7a4acd3"), new Guid("5eaa27aa-319b-4f2f-a068-f852531b80ad"), "en", "Sumy" },
                    { new Guid("7c30c247-f499-4978-973f-9c4b95c70027"), new Guid("25777b82-798b-46ff-8e79-5d9eee60b090"), "en", "Zaporizhzhia" },
                    { new Guid("7eb32d91-feb7-4b45-b1e0-95da209bdb5e"), new Guid("127e6bf5-9cb4-4219-aa99-85e678864ed5"), "uk", "Херсон" },
                    { new Guid("7f735e7e-de68-4c58-a466-7e3d9c0015b8"), new Guid("2d50b9de-cdc5-40b9-8ee2-1db6db29ecf6"), "uk", "Люблін" },
                    { new Guid("809ae962-8ec1-486a-a7ac-34b23dd3170c"), new Guid("05a12e22-f5c3-4c69-a2b5-b65cd118c752"), "uk", "Тернопіль" },
                    { new Guid("8183d17b-47f0-445d-bdc8-91b1d3785b35"), new Guid("127e6bf5-9cb4-4219-aa99-85e678864ed5"), "en", "Kherson" },
                    { new Guid("86c651aa-b680-4d9b-b340-6f725e17594c"), new Guid("34700f20-3e77-4ad2-af01-c93c851dcdd7"), "uk", "Миколаїв" },
                    { new Guid("8a42ba60-10b9-4db0-a97c-3f8228f7625b"), new Guid("25777b82-798b-46ff-8e79-5d9eee60b090"), "uk", "Запоріжжя" },
                    { new Guid("8b3ddb96-4990-4a5d-b481-40a5f1a128b8"), new Guid("eb734b8e-e223-4eb1-addf-7960dc06ddc4"), "uk", "Хмельницький" },
                    { new Guid("8d754d7f-60ec-4ab0-b19d-bb725a67fe13"), new Guid("21392d0c-2b1c-4f29-bb75-13cbeb445e47"), "en", "Cherkasy" },
                    { new Guid("94621098-d060-4171-83b3-6b67fa3a1c2b"), new Guid("71c6eec0-012b-4436-9e9f-882d00f83f16"), "uk", "Чернівці" },
                    { new Guid("94d3d8f7-e280-4bb9-a75a-d82f167ef928"), new Guid("34700f20-3e77-4ad2-af01-c93c851dcdd7"), "en", "Mykolaiv" },
                    { new Guid("96eb10e8-6b27-42cf-bee5-cdef94725b16"), new Guid("15ad2297-c9dc-4d29-97ce-7e668cbb1d38"), "uk", "Харків" },
                    { new Guid("97c5e1cf-3d6b-4000-980d-92eb890a8288"), new Guid("2a68db21-dcc1-4bd2-beb9-d1ba44468bd6"), "en", "Zhytomyr" },
                    { new Guid("9b11140c-8c63-4dbb-8e09-f8560e89ea30"), new Guid("b9bbe674-e9a7-4464-86ff-df7e850bf7f1"), "en", "Lutsk" },
                    { new Guid("aef25643-0c95-4491-ba95-81d2bfa22244"), new Guid("dd2bda82-ff64-40e6-be42-51f79f53c05e"), "uk", "Рівне" },
                    { new Guid("caddd4a7-3285-4732-8241-a25931c8e6bc"), new Guid("a837f771-78d3-495d-bed6-ef9162d444ac"), "en", "Odesa" },
                    { new Guid("cbd921c8-549b-4e6a-981d-fb0f58cbe2b4"), new Guid("dd2bda82-ff64-40e6-be42-51f79f53c05e"), "en", "Rivne" },
                    { new Guid("d48ffa92-086e-46eb-abfd-fe43b0f16c69"), new Guid("e50cfd5c-f728-43c2-9474-5cc744295f29"), "en", "Ivano-Frankivsk" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d945082f-0d45-4198-8dad-1ff7e05eae39"), new Guid("21392d0c-2b1c-4f29-bb75-13cbeb445e47"), "uk", "Черкаси" },
                    { new Guid("e9a4463f-a970-44c0-917e-c5f24b0c313f"), new Guid("56a792e5-7166-4269-a5d4-b5d9a0e3a960"), "en", "Poltava" },
                    { new Guid("e9ca9b6b-df9d-4a2a-826d-f574b94c7a5f"), new Guid("1963d595-2df5-4bf3-95e3-e50bf2151277"), "uk", "Київ" },
                    { new Guid("ec89d3af-d1f1-495d-9c8a-50622f9dd61b"), new Guid("ad32f639-0a8a-4bef-ab88-53d45b8c2814"), "uk", "Варшава" },
                    { new Guid("f637d796-9c3b-4e47-9c78-04d1223f4467"), new Guid("05a12e22-f5c3-4c69-a2b5-b65cd118c752"), "en", "Ternopil" },
                    { new Guid("f9d51154-56ab-4cf3-b66f-e30e5e91dfb3"), new Guid("ad32f639-0a8a-4bef-ab88-53d45b8c2814"), "en", "Varshava" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("8c97202e-4f74-4c5d-bcd4-0a53a46f9660"), new Guid("9a5b8e47-eeae-4ce5-8843-ada8b9eb8f8d"), new DateTime(2023, 4, 28, 22, 26, 40, 843, DateTimeKind.Local).AddTicks(7189), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

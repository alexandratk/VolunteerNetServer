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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredNumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    NumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
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
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("70ed4402-7dc0-4465-958b-7bce58ec0b5a"), "pl" },
                    { new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("62c7465a-a926-458c-8058-9d1ce7addc44"), "cooking" },
                    { new Guid("81f5bff9-a3a9-41f4-937d-f4f233620f38"), "psychology" },
                    { new Guid("9bf84605-630e-4e74-a15b-3c4ee6569d2d"), "building" },
                    { new Guid("d16b6a31-5241-4c76-b197-ea73336fc66b"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("084a5d4b-3d1e-4e99-933e-af2f327d90d3"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "vi" },
                    { new Guid("1f6e3b35-2031-4f44-a28d-830e15d8fb66"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "uzh" },
                    { new Guid("48ee6cbe-ab0b-43bd-8aeb-b412c8ac62a1"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "if" },
                    { new Guid("4ac26f07-ee56-4e5d-ac5b-209c2d7be33f"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "dn" },
                    { new Guid("541c7423-bb85-428f-a671-fa60de75b455"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "ky" },
                    { new Guid("627e5434-5e3d-4809-870b-42bf2896276c"), new Guid("70ed4402-7dc0-4465-958b-7bce58ec0b5a"), "lub" },
                    { new Guid("6311cbc0-e19d-4fc4-85ed-e9d56a0f28b7"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "ri" },
                    { new Guid("6aba5a0a-8692-4008-a835-ccfeab512ccb"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "kher" },
                    { new Guid("6c52291c-4a69-461b-a028-9eb46922db1c"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "khar" },
                    { new Guid("73a50d89-a2c4-41ae-8081-fe68d9c6775e"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "kr" },
                    { new Guid("8029a730-a2aa-4e16-9513-eb21f6d00ed2"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "zp" },
                    { new Guid("916e6dae-c443-48e5-a58e-a9a7b5f70c1f"), new Guid("70ed4402-7dc0-4465-958b-7bce58ec0b5a"), "var" },
                    { new Guid("91fcb14c-24eb-4dea-8212-657da3f6a9c8"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "zhy" },
                    { new Guid("9f82d527-a4c9-4e89-a05a-26d628f75591"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "chv" },
                    { new Guid("a08b134d-d7ba-43fa-849d-04bfb9129a41"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "khm" },
                    { new Guid("af53446f-14bd-48f0-a03e-50c9c78a4de5"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "ter" },
                    { new Guid("c4170339-d69d-4277-a0ea-de8fe5181882"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "chk" },
                    { new Guid("d24c4f9d-bc53-446d-9740-54bc55fcbbfc"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "lv" },
                    { new Guid("d454a0ff-a55a-47d0-8117-0518c4138c03"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "pol" },
                    { new Guid("d9c93333-c1b3-4948-ad78-a3da70e5a04d"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "su" },
                    { new Guid("df31eb8a-3c9f-4a96-8468-ba9b050fab6d"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "lut" },
                    { new Guid("e1ed30e2-01f6-479b-afe8-536c169bb35b"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "my" },
                    { new Guid("e6081aa1-0a4f-46e0-8d28-20cacc97bee5"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "od" },
                    { new Guid("eae60ac4-527f-4cda-a041-7b5797410732"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "chh" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("169fb195-2c56-435c-9b41-bf11e369c942"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "en", "Ukraine" },
                    { new Guid("420a43c9-86c9-429e-bd3a-ff6509753211"), new Guid("fd109275-a02d-481d-ae88-0f0345760922"), "uk", "Україна" },
                    { new Guid("55533d36-2907-45d8-95c4-7a51737023f0"), new Guid("70ed4402-7dc0-4465-958b-7bce58ec0b5a"), "en", "Poland" },
                    { new Guid("9f5404c6-8f65-4d7d-a113-41001e40e386"), new Guid("70ed4402-7dc0-4465-958b-7bce58ec0b5a"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("2f5d3a78-6400-4ed4-ad1a-8cfd57f0d4af"), "en", "building", new Guid("9bf84605-630e-4e74-a15b-3c4ee6569d2d") },
                    { new Guid("34ea0bff-a529-49df-895c-fc595279863a"), "uk", "кулінарія", new Guid("62c7465a-a926-458c-8058-9d1ce7addc44") },
                    { new Guid("3b9d5509-d339-47c9-8662-8bd87c65c1cf"), "uk", "психологія", new Guid("81f5bff9-a3a9-41f4-937d-f4f233620f38") },
                    { new Guid("536107f5-f48e-44ec-81ab-325d82e2d843"), "en", "psychology", new Guid("81f5bff9-a3a9-41f4-937d-f4f233620f38") },
                    { new Guid("9ee3e6b8-c6f4-4462-9524-45da3e30bf79"), "en", "cooking", new Guid("62c7465a-a926-458c-8058-9d1ce7addc44") },
                    { new Guid("cd1eaeb8-ba87-46c8-ac6e-49d973f856c6"), "en", "medicine", new Guid("d16b6a31-5241-4c76-b197-ea73336fc66b") },
                    { new Guid("e3241c0f-d1f0-4278-86b3-a43d89e6dce5"), "uk", "медицина", new Guid("d16b6a31-5241-4c76-b197-ea73336fc66b") },
                    { new Guid("ed2dff62-1356-46eb-8e7a-6fd67c84eec5"), "uk", "будівництво", new Guid("9bf84605-630e-4e74-a15b-3c4ee6569d2d") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("01e01659-50b5-42b9-bdae-14a5b9d4c6ed"), new Guid("d24c4f9d-bc53-446d-9740-54bc55fcbbfc"), "uk", "Львів" },
                    { new Guid("06f11f58-79b7-4d5a-87e5-f23ee5acccbe"), new Guid("df31eb8a-3c9f-4a96-8468-ba9b050fab6d"), "en", "Lutsk" },
                    { new Guid("0d97d483-0d58-4ce6-81f6-175380cde2fc"), new Guid("084a5d4b-3d1e-4e99-933e-af2f327d90d3"), "uk", "Вінниця" },
                    { new Guid("0f59fde6-0f68-4f68-ac83-adf475b0fa46"), new Guid("e1ed30e2-01f6-479b-afe8-536c169bb35b"), "en", "Mykolaiv" },
                    { new Guid("14478911-5782-4cf6-9dfb-f0e9ceb60ad5"), new Guid("e1ed30e2-01f6-479b-afe8-536c169bb35b"), "uk", "Миколаїв" },
                    { new Guid("1a099818-1c90-4907-bc37-5e7653ddf461"), new Guid("a08b134d-d7ba-43fa-849d-04bfb9129a41"), "en", "Khmelnytskyi" },
                    { new Guid("2613c2e4-eff1-46be-9f53-9555d3fe1370"), new Guid("8029a730-a2aa-4e16-9513-eb21f6d00ed2"), "uk", "Запоріжжя" },
                    { new Guid("26388514-108c-40f4-8e8a-3e196ddd1e68"), new Guid("a08b134d-d7ba-43fa-849d-04bfb9129a41"), "uk", "Хмельницький" },
                    { new Guid("29995cd5-971b-473d-8cd5-1000dc13b189"), new Guid("541c7423-bb85-428f-a671-fa60de75b455"), "en", "Kyiv" },
                    { new Guid("2ba5d89a-67fe-4f7c-afbc-81e4968c5395"), new Guid("eae60ac4-527f-4cda-a041-7b5797410732"), "en", "Chernihiv" },
                    { new Guid("2da4d7aa-58f2-440f-8fdc-e0c805fa6b68"), new Guid("6c52291c-4a69-461b-a028-9eb46922db1c"), "en", "Kharkiv" },
                    { new Guid("2fde78aa-d9ab-41ad-a587-49d2702d1368"), new Guid("d24c4f9d-bc53-446d-9740-54bc55fcbbfc"), "en", "Lviv" },
                    { new Guid("312f6d95-56fe-47c3-9b84-4b66d3af07a1"), new Guid("1f6e3b35-2031-4f44-a28d-830e15d8fb66"), "uk", "Ужгород" },
                    { new Guid("32c4b531-c278-4c81-9599-f8e2f0a15bb2"), new Guid("af53446f-14bd-48f0-a03e-50c9c78a4de5"), "uk", "Тернопіль" },
                    { new Guid("34fde5d5-b770-4401-ac74-5403963fc5bb"), new Guid("1f6e3b35-2031-4f44-a28d-830e15d8fb66"), "en", "Uzhhorod" },
                    { new Guid("42cda36f-eb24-4efa-a3c7-2486bcd94e65"), new Guid("6311cbc0-e19d-4fc4-85ed-e9d56a0f28b7"), "en", "Rivne" },
                    { new Guid("45c12fb7-2212-493f-a110-e5af64d05d24"), new Guid("73a50d89-a2c4-41ae-8081-fe68d9c6775e"), "uk", "Кропивницький" },
                    { new Guid("461c0484-a37f-42cf-92bb-8a9ca2db5403"), new Guid("4ac26f07-ee56-4e5d-ac5b-209c2d7be33f"), "en", "Dnipro" },
                    { new Guid("48763c49-b585-4c0b-8c21-cb5307af20f2"), new Guid("6c52291c-4a69-461b-a028-9eb46922db1c"), "uk", "Харків" },
                    { new Guid("53be6c95-4298-490c-9cc7-03d326eb592f"), new Guid("af53446f-14bd-48f0-a03e-50c9c78a4de5"), "en", "Ternopil" },
                    { new Guid("5ed1a218-dde2-4b0a-88e6-2eca27422f32"), new Guid("48ee6cbe-ab0b-43bd-8aeb-b412c8ac62a1"), "uk", "Івано-Франківськ" },
                    { new Guid("5f22fd90-6acf-42a4-be3b-872664c2284c"), new Guid("6aba5a0a-8692-4008-a835-ccfeab512ccb"), "uk", "Херсон" },
                    { new Guid("6019e78c-e888-4128-ac43-2756a27d54d2"), new Guid("8029a730-a2aa-4e16-9513-eb21f6d00ed2"), "en", "Zaporizhzhia" },
                    { new Guid("61dc5944-c14d-4363-b7bc-aee221181032"), new Guid("916e6dae-c443-48e5-a58e-a9a7b5f70c1f"), "en", "Varshava" },
                    { new Guid("63ef3ef7-0abc-4ad6-9a45-8cf26ef69b49"), new Guid("d454a0ff-a55a-47d0-8117-0518c4138c03"), "en", "Poltava" },
                    { new Guid("666c5bfc-888a-498b-b7d3-10c2270e9c01"), new Guid("e6081aa1-0a4f-46e0-8d28-20cacc97bee5"), "en", "Odesa" },
                    { new Guid("6db2c274-da42-4c07-a0c1-0c318a5903cf"), new Guid("91fcb14c-24eb-4dea-8212-657da3f6a9c8"), "uk", "Житомир" },
                    { new Guid("6e6ad2a1-fbe6-41ab-af2c-95d90423d9e3"), new Guid("d9c93333-c1b3-4948-ad78-a3da70e5a04d"), "uk", "Суми" },
                    { new Guid("73f5b847-0349-438c-965d-71b8aa01236a"), new Guid("df31eb8a-3c9f-4a96-8468-ba9b050fab6d"), "uk", "Луцьк" },
                    { new Guid("7fb05809-5125-492d-bb6d-1a0f8d700a08"), new Guid("9f82d527-a4c9-4e89-a05a-26d628f75591"), "uk", "Чернівці" },
                    { new Guid("84060f94-df4a-4c85-b29c-d1afe7457d8f"), new Guid("c4170339-d69d-4277-a0ea-de8fe5181882"), "uk", "Черкаси" },
                    { new Guid("89962108-8a1b-41ea-bd52-1d4999c69382"), new Guid("084a5d4b-3d1e-4e99-933e-af2f327d90d3"), "en", "Vinnytsia" },
                    { new Guid("8b024fb6-50c8-444a-91a0-26584c07b8ea"), new Guid("6311cbc0-e19d-4fc4-85ed-e9d56a0f28b7"), "uk", "Рівне" },
                    { new Guid("8ed57b96-9feb-48a9-9ad2-dc2d14d62ae6"), new Guid("c4170339-d69d-4277-a0ea-de8fe5181882"), "en", "Cherkasy" },
                    { new Guid("9cbca3d6-0353-42af-93e7-dd9744f67a2a"), new Guid("627e5434-5e3d-4809-870b-42bf2896276c"), "en", "Lublin" },
                    { new Guid("aa5b5a29-65c4-45dd-b468-463dc7af75a3"), new Guid("4ac26f07-ee56-4e5d-ac5b-209c2d7be33f"), "uk", "Дніпро" },
                    { new Guid("abde2381-433d-4ecc-90bf-ba92346728ee"), new Guid("e6081aa1-0a4f-46e0-8d28-20cacc97bee5"), "uk", "Одеса" },
                    { new Guid("afb547a6-1419-4912-90fd-ce5ce0c625d4"), new Guid("541c7423-bb85-428f-a671-fa60de75b455"), "uk", "Київ" },
                    { new Guid("b22ea3d6-750f-4266-b126-18443c2273bb"), new Guid("d9c93333-c1b3-4948-ad78-a3da70e5a04d"), "en", "Sumy" },
                    { new Guid("b7fd7b9b-5ff7-46c1-92d4-29133d86c5dc"), new Guid("eae60ac4-527f-4cda-a041-7b5797410732"), "uk", "Чернігів" },
                    { new Guid("ba1a2c76-00fe-49b8-af3c-cb0c637837c2"), new Guid("9f82d527-a4c9-4e89-a05a-26d628f75591"), "en", "Chernivtsi" },
                    { new Guid("bb1de9d4-de19-4d05-bfcd-1a7f5ad5c882"), new Guid("d454a0ff-a55a-47d0-8117-0518c4138c03"), "uk", "Полтава" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("c6a4ee5b-4ae9-42a5-8721-bb4672498140"), new Guid("6aba5a0a-8692-4008-a835-ccfeab512ccb"), "en", "Kherson" },
                    { new Guid("c759cf50-af0b-413b-9a8c-6b092c016775"), new Guid("627e5434-5e3d-4809-870b-42bf2896276c"), "uk", "Люблін" },
                    { new Guid("cbd5dbc0-de68-40f7-9d80-ff2c0affe671"), new Guid("916e6dae-c443-48e5-a58e-a9a7b5f70c1f"), "uk", "Варшава" },
                    { new Guid("d57fe152-094d-4776-969d-165e77a45dd2"), new Guid("48ee6cbe-ab0b-43bd-8aeb-b412c8ac62a1"), "en", "Ivano-Frankivsk" },
                    { new Guid("f1c872c4-e760-4482-8241-5104ec249198"), new Guid("73a50d89-a2c4-41ae-8081-fe68d9c6775e"), "en", "Kropyvnytskyi" },
                    { new Guid("f8cc63cf-7347-4c32-bc0a-8c975fc61e63"), new Guid("91fcb14c-24eb-4dea-8212-657da3f6a9c8"), "en", "Zhytomyr" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("ff10d8df-2432-4f9c-84f7-21e57514142a"), new Guid("084a5d4b-3d1e-4e99-933e-af2f327d90d3"), new DateTime(2023, 5, 2, 15, 51, 51, 5, DateTimeKind.Local).AddTicks(4506), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CityId",
                table: "Applications",
                column: "CityId");

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

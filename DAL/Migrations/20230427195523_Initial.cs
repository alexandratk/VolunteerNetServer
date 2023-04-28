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
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
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
                    VolunteerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Volunteers_VolunteerId_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("129efdf6-5bea-4767-8fab-97f7925de5c4"), "pl" },
                    { new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("6955eb17-236d-457e-857c-905d32371c69"), "psychology" },
                    { new Guid("81bb520a-1884-4715-822f-48600f867f9c"), "building" },
                    { new Guid("9fd6c325-b504-4358-9f5f-76ec4cf73c73"), "cooking" },
                    { new Guid("ac0f0563-b401-4eda-bd6a-86ad1028a1e5"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("01331e3d-c2d4-4f2c-9296-2205735e4b1a"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "pol" },
                    { new Guid("1fbc2dba-18b6-4e0a-8f27-6d2d1b8dd70c"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "dn" },
                    { new Guid("3ced847e-a8ed-4218-bcfe-6b5e79df8b06"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "zp" },
                    { new Guid("40d7c2b4-ecad-4c9e-a49b-694cae3e7b3c"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "ky" },
                    { new Guid("463fad84-1917-43ab-943a-2446b7d12be8"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "chh" },
                    { new Guid("4d655442-e406-4f5d-99b7-86a37d2cf4d8"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "chk" },
                    { new Guid("57ccc51d-838e-41ca-a938-525ccf594575"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "kr" },
                    { new Guid("5afca0c8-e537-4d17-b08e-96f99e4cc8c1"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "vi" },
                    { new Guid("774d5c09-d3f7-4c45-af81-cc9113da435e"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "chv" },
                    { new Guid("778c5508-38ee-4a59-9b27-2b150510041c"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "su" },
                    { new Guid("8848c278-99f6-41b5-9c51-05999da664be"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "ri" },
                    { new Guid("9a53061c-f6fa-47a9-984d-68bd207bbe63"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "lut" },
                    { new Guid("9d2415a6-4687-4203-a267-69e1752d4a24"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "khar" },
                    { new Guid("9fb59cfd-76ab-4165-83c3-961851b7315d"), new Guid("129efdf6-5bea-4767-8fab-97f7925de5c4"), "var" },
                    { new Guid("bb19cb49-98ed-4d4a-b203-b84e9c1a3c75"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "od" },
                    { new Guid("bb7c6234-2c3b-42ea-9ae7-5be22b630dad"), new Guid("129efdf6-5bea-4767-8fab-97f7925de5c4"), "lub" },
                    { new Guid("cd868940-1ee9-4aba-858e-997ad20b60a7"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "ter" },
                    { new Guid("d6c6a119-3bd4-4704-bd39-713d49258996"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "if" },
                    { new Guid("e8e38952-a6ab-45b4-8c24-f17a45bd515f"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "my" },
                    { new Guid("ed1173b7-ce8b-40ff-9f28-e53312ba8954"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "zhy" },
                    { new Guid("ef4d43cd-e75c-4a72-9ae5-9c8b7e8fce72"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "khm" },
                    { new Guid("ef97b43b-525c-4a53-8828-cd9c96f2ee42"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "uzh" },
                    { new Guid("f442a29c-4f82-4aa7-9689-b88680eaef93"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "lv" },
                    { new Guid("f587378b-09bf-4659-86c8-038b3160d0b3"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "kher" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("185da1d9-fb24-4c8c-8a07-967ba3d99cdc"), new Guid("129efdf6-5bea-4767-8fab-97f7925de5c4"), "en", "Poland" },
                    { new Guid("28125b9b-2578-497c-b2b6-d48242390fc4"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "uk", "Україна" },
                    { new Guid("ca8d5ec8-7198-405f-805b-eff8d9c8c882"), new Guid("129efdf6-5bea-4767-8fab-97f7925de5c4"), "uk", "Польша" },
                    { new Guid("db8da78f-bd45-4d6d-85ee-ac5321c420af"), new Guid("92bfd562-df99-49c0-9670-c34a51e37772"), "en", "Ukraine" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("05e07eac-bc9c-4c19-9270-dd7cdb412b66"), "uk", "медицина", new Guid("ac0f0563-b401-4eda-bd6a-86ad1028a1e5") },
                    { new Guid("36f52c60-3192-45dc-bc52-ec2c5621e5c3"), "en", "building", new Guid("81bb520a-1884-4715-822f-48600f867f9c") },
                    { new Guid("49b11c61-55ec-4fe6-90c6-5a458a7a38bf"), "en", "psychology", new Guid("6955eb17-236d-457e-857c-905d32371c69") },
                    { new Guid("6da99f29-ed4f-48e7-b75d-0d8416618b0e"), "uk", "психологія", new Guid("6955eb17-236d-457e-857c-905d32371c69") },
                    { new Guid("71c57c5c-b308-4a4e-b2d2-879ccbe3d9f2"), "en", "cooking", new Guid("9fd6c325-b504-4358-9f5f-76ec4cf73c73") },
                    { new Guid("dd7e0989-c44f-45fe-a928-8aa270ff05e7"), "en", "medicine", new Guid("ac0f0563-b401-4eda-bd6a-86ad1028a1e5") },
                    { new Guid("f63afdd6-c75d-456e-a2b0-113d40fe5f39"), "uk", "кулінарія", new Guid("9fd6c325-b504-4358-9f5f-76ec4cf73c73") },
                    { new Guid("f7e465ac-3fe6-4b43-9d45-2f7704df61d0"), "uk", "будівництво", new Guid("81bb520a-1884-4715-822f-48600f867f9c") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0aadc5fe-e9fd-464b-af8e-cf4055d15885"), new Guid("f442a29c-4f82-4aa7-9689-b88680eaef93"), "en", "Lviv" },
                    { new Guid("153a8eca-0a36-4880-a705-301cad31594e"), new Guid("ed1173b7-ce8b-40ff-9f28-e53312ba8954"), "uk", "Житомир" },
                    { new Guid("1a9f78d3-891a-4496-8845-ed23b0a3738a"), new Guid("8848c278-99f6-41b5-9c51-05999da664be"), "en", "Rivne" },
                    { new Guid("22b6e9ec-63e1-4bbf-881f-94a712e3c43e"), new Guid("cd868940-1ee9-4aba-858e-997ad20b60a7"), "en", "Ternopil" },
                    { new Guid("24122ae4-f1cc-4e1b-b495-a7ae67f6b2bd"), new Guid("01331e3d-c2d4-4f2c-9296-2205735e4b1a"), "en", "Poltava" },
                    { new Guid("2df7ae83-bd1b-4c3a-be85-e7ade575fa9b"), new Guid("bb7c6234-2c3b-42ea-9ae7-5be22b630dad"), "en", "Lublin" },
                    { new Guid("348c3ae8-a735-4efa-91a6-9105b4133176"), new Guid("e8e38952-a6ab-45b4-8c24-f17a45bd515f"), "uk", "Миколаїв" },
                    { new Guid("3bd2f32f-2ed8-445a-9a90-31ba01407e97"), new Guid("1fbc2dba-18b6-4e0a-8f27-6d2d1b8dd70c"), "en", "Dnipro" },
                    { new Guid("46882d7f-8d2b-4e4a-a7b7-10899effd726"), new Guid("774d5c09-d3f7-4c45-af81-cc9113da435e"), "uk", "Чернівці" },
                    { new Guid("47f1d312-2698-42e1-a3e9-6141ae8c13bd"), new Guid("5afca0c8-e537-4d17-b08e-96f99e4cc8c1"), "uk", "Вінниця" },
                    { new Guid("4c1ac5ba-f948-47d5-8493-031291286871"), new Guid("ed1173b7-ce8b-40ff-9f28-e53312ba8954"), "en", "Zhytomyr" },
                    { new Guid("529ff0d9-6bae-4432-9ccd-20b04dc0cea0"), new Guid("9fb59cfd-76ab-4165-83c3-961851b7315d"), "uk", "Варшава" },
                    { new Guid("5a849e7b-d589-4d10-9e76-b10c295dd1a1"), new Guid("778c5508-38ee-4a59-9b27-2b150510041c"), "en", "Sumy" },
                    { new Guid("5d92030c-b2ad-4e7b-af87-8ef9c04818e2"), new Guid("9a53061c-f6fa-47a9-984d-68bd207bbe63"), "uk", "Луцьк" },
                    { new Guid("60009f07-b2c8-4e6d-a5c7-6c5c6ebf7c34"), new Guid("d6c6a119-3bd4-4704-bd39-713d49258996"), "uk", "Івано-Франківськ" },
                    { new Guid("6288b79e-dfa2-46b3-8080-adefa30c05e4"), new Guid("e8e38952-a6ab-45b4-8c24-f17a45bd515f"), "en", "Mykolaiv" },
                    { new Guid("65f5ac76-f407-4ae4-894e-36151638a67b"), new Guid("3ced847e-a8ed-4218-bcfe-6b5e79df8b06"), "en", "Zaporizhzhia" },
                    { new Guid("67dbb00b-ad31-4a33-9ae0-c28b2fda292d"), new Guid("9d2415a6-4687-4203-a267-69e1752d4a24"), "uk", "Харків" },
                    { new Guid("6aed6c00-c913-4773-97be-26ba00e5a392"), new Guid("f587378b-09bf-4659-86c8-038b3160d0b3"), "uk", "Херсон" },
                    { new Guid("721695a7-160c-4fc0-a7c5-a0f497e94827"), new Guid("bb19cb49-98ed-4d4a-b203-b84e9c1a3c75"), "uk", "Одеса" },
                    { new Guid("75b64f58-c0c3-4d6c-9b49-15dab9e16db2"), new Guid("40d7c2b4-ecad-4c9e-a49b-694cae3e7b3c"), "uk", "Київ" },
                    { new Guid("7ce2d04c-40c5-401a-b945-219f92fbd52f"), new Guid("ef97b43b-525c-4a53-8828-cd9c96f2ee42"), "uk", "Ужгород" },
                    { new Guid("7f125352-9a4d-41eb-b7d4-657e5375acd4"), new Guid("778c5508-38ee-4a59-9b27-2b150510041c"), "uk", "Суми" },
                    { new Guid("89b13458-f824-4ec5-a571-1de81a2599a0"), new Guid("9fb59cfd-76ab-4165-83c3-961851b7315d"), "en", "Varshava" },
                    { new Guid("8beed449-f2be-40bf-bb44-deaa4a66abcc"), new Guid("f442a29c-4f82-4aa7-9689-b88680eaef93"), "uk", "Львів" },
                    { new Guid("93524438-fedc-47f2-8d6a-c8988fafc25b"), new Guid("5afca0c8-e537-4d17-b08e-96f99e4cc8c1"), "en", "Vinnytsia" },
                    { new Guid("93bbd720-f8be-4a73-97ef-89f628e948b0"), new Guid("01331e3d-c2d4-4f2c-9296-2205735e4b1a"), "uk", "Полтава" },
                    { new Guid("9501cbc1-6ac5-43b6-b2ce-07014c07c383"), new Guid("1fbc2dba-18b6-4e0a-8f27-6d2d1b8dd70c"), "uk", "Дніпро" },
                    { new Guid("9808bc29-b36b-4b1f-95f9-cecd2a56dc91"), new Guid("774d5c09-d3f7-4c45-af81-cc9113da435e"), "en", "Chernivtsi" },
                    { new Guid("98e851cd-99fc-4237-baba-996573bf2f48"), new Guid("9a53061c-f6fa-47a9-984d-68bd207bbe63"), "en", "Lutsk" },
                    { new Guid("99bed382-4e8e-429e-bbfe-f27a608eb914"), new Guid("8848c278-99f6-41b5-9c51-05999da664be"), "uk", "Рівне" },
                    { new Guid("9bfeaaee-1688-48d7-8ca6-6230a53e9988"), new Guid("ef4d43cd-e75c-4a72-9ae5-9c8b7e8fce72"), "en", "Khmelnytskyi" },
                    { new Guid("9c1fc5ae-8b70-464c-9761-b4e69a405f1a"), new Guid("bb19cb49-98ed-4d4a-b203-b84e9c1a3c75"), "en", "Odesa" },
                    { new Guid("9dce8ef5-93a1-45b5-9542-ced5ec478c22"), new Guid("ef97b43b-525c-4a53-8828-cd9c96f2ee42"), "en", "Uzhhorod" },
                    { new Guid("b33fe486-5962-4922-b6c4-de64bb40ef22"), new Guid("3ced847e-a8ed-4218-bcfe-6b5e79df8b06"), "uk", "Запоріжжя" },
                    { new Guid("ba210f5a-373f-45b2-adad-e77a3b7cf05d"), new Guid("cd868940-1ee9-4aba-858e-997ad20b60a7"), "uk", "Тернопіль" },
                    { new Guid("bfb9818d-5762-4dfb-9b55-73cf32f39367"), new Guid("40d7c2b4-ecad-4c9e-a49b-694cae3e7b3c"), "en", "Kyiv" },
                    { new Guid("caf8da75-822c-4c15-8e11-55773ee5468a"), new Guid("ef4d43cd-e75c-4a72-9ae5-9c8b7e8fce72"), "uk", "Хмельницький" },
                    { new Guid("cecb49a2-67ad-46c9-a1a5-e4b3a585f49b"), new Guid("bb7c6234-2c3b-42ea-9ae7-5be22b630dad"), "uk", "Люблін" },
                    { new Guid("cfe4c868-a333-4c3e-8119-bffd998e5de8"), new Guid("4d655442-e406-4f5d-99b7-86a37d2cf4d8"), "en", "Cherkasy" },
                    { new Guid("d25d265c-dcd6-4a5c-bb90-5074a74c3f8a"), new Guid("57ccc51d-838e-41ca-a938-525ccf594575"), "en", "Kropyvnytskyi" },
                    { new Guid("d359c66c-8954-49de-96f9-32d58d7feeb0"), new Guid("57ccc51d-838e-41ca-a938-525ccf594575"), "uk", "Кропивницький" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d5cec7a7-17fa-4f87-a3dd-83092ba68715"), new Guid("463fad84-1917-43ab-943a-2446b7d12be8"), "en", "Chernihiv" },
                    { new Guid("d89d5868-5a8e-4629-929c-e6fcc054d490"), new Guid("9d2415a6-4687-4203-a267-69e1752d4a24"), "en", "Kharkiv" },
                    { new Guid("dba0baf6-a6d7-4b6e-878a-39abc26c5d54"), new Guid("4d655442-e406-4f5d-99b7-86a37d2cf4d8"), "uk", "Черкаси" },
                    { new Guid("dc877c4e-5271-412b-9f87-8c52621af3db"), new Guid("d6c6a119-3bd4-4704-bd39-713d49258996"), "en", "Ivano-Frankivsk" },
                    { new Guid("e2883d65-ddeb-4ae8-b585-e24e9e3eb167"), new Guid("f587378b-09bf-4659-86c8-038b3160d0b3"), "en", "Kherson" },
                    { new Guid("f323ab58-93da-4f36-a0b7-7dc39abb644d"), new Guid("463fad84-1917-43ab-943a-2446b7d12be8"), "uk", "Чернігів" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("aaab5803-b509-40b4-91c0-a239022426ae"), new Guid("5afca0c8-e537-4d17-b08e-96f99e4cc8c1"), new DateTime(2023, 4, 27, 22, 55, 21, 67, DateTimeKind.Local).AddTicks(5391), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

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

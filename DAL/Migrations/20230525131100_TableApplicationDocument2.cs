using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class TableApplicationDocument2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationDocuments_Applications_ApplicationId",
                table: "ApplicationDocuments");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("03e1fd94-ec43-481a-915e-431f1f60ee9d"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("147e633e-6c29-4484-9230-a054f984d06a"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("67a55bc8-f684-40d3-ae91-5ba26d25ec1f"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7d07ef65-6ce8-41e4-b249-b578d9c5057d"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("84216b51-84aa-4ce8-b2fe-8c4426883615"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("958602e1-bd60-4cb8-b541-00dafe3bf086"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("99a9bcf6-26a3-4782-86a6-0b767a954250"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b456e736-4a33-4e4e-bb83-3cadb7fec609"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e23da740-8efe-42bd-a45b-e416265df134"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f4c05e1a-bc7c-4c20-b921-03f330c5eafb"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("01f39cc1-9917-4719-a9f1-c19c5581fe60"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("03813f27-a0a5-4c65-b0c2-45dedc212a06"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("03b11763-bbfa-4383-b443-9504f7efe64a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("048133cc-2327-4c4f-ba59-b4b768415802"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("04cb560e-c607-4efc-877d-340dfde24e03"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0d75d80d-20bb-49a4-9a61-2a9d75d26079"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1909f673-cf97-4181-9bc7-7029baffc64a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1bbf210e-3e1b-4f19-b8dd-dc2e7b04b62f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1ebb665d-8468-46e0-890c-3ccdc63ae881"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("28078ac8-a640-459a-b6fd-c93819ab90c5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("34662c56-e820-4ac2-86d4-2a493a0ed902"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("39088edb-1e80-448f-a805-404978e37548"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3dfb147f-f486-4790-baab-09df76ce0f5c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3f7e5538-25f7-4a8f-98bc-f07ba702338c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3ff23279-4ada-4448-90ca-8ff31f458b7c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("40b1dbc4-c5e1-465a-9273-c922c4e29a5d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4101f4a4-c93b-4538-b852-6e7c1a6fc8c5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("49dd8861-f844-4aa3-bea6-6aa7365cc8dd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4a787f71-5f88-41e3-ad52-7eef108afafc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4ea83fb3-d1eb-4c91-96fd-408e2f1fd269"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("55913e4e-90a4-40eb-ae0a-1bbb97697e29"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("55fd5c22-84b4-4ae3-a350-8eb2f51a7ab9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("57945bd6-5a43-4832-b822-09bf9e67cdb7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("688c2654-3705-4ca9-b927-bf5240bc350b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("68d38896-4d6d-4a45-8166-8d807a7b0a26"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6a060bfe-1962-4794-971b-cea8def720ad"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6a428be9-f4f2-46b4-b3bd-83779483f425"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6b93a13d-2ccf-4676-b4cf-700d69b153d7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("756ef16d-d73d-4e16-93bf-9a20ad56661e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8380a125-8dcb-404a-8c61-ff874128d3ff"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("957737dd-267b-45c5-8214-d61986816862"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9d764410-1546-448b-a09f-f38feebf8ec6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b179d4a9-2dab-420c-9e13-6857e6cde433"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b7d85eee-18b9-40bc-8bf7-760ad7a3f97e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c209d18a-5435-4700-ba95-7b08b65be6bc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cb3f4efb-d455-49c5-b20d-7c38a9a76a26"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d4d14e1a-d24e-4e1f-aad8-c24555fb0f08"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d528d578-27fb-488b-a231-90cf2b6200b0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d5f34dc3-d9f7-4731-9339-aa92d674a209"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ddd7d3c6-4846-42ab-833e-21d1b619712b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("df476c59-8e07-43fd-9d39-7daf828d159e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dfa539f8-7362-458c-89d5-8d7050738159"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e8985247-f3f4-4a03-939a-7ed0c842b2a5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ed279664-7198-4051-9d75-e7711f9459c7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ed4e3f5f-ea94-4f33-999b-bc614774a9c5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("edfbefca-f0f1-4a4f-a063-479e38d36fd7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f0a97eab-5281-49c0-a165-645ffadd540d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fc849a5f-76c8-4e2a-9834-c4777ac45965"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1dac11b7-1aca-4f70-b1ca-4e18e3919885"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ab91f884-8b1e-4b98-9caa-6a2eb154fc91"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ba0c5939-fa38-431a-aa96-c403bf6eb956"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ff90ee03-f699-499a-bf4c-73f79e7ceac6"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1a066b47-09d1-46fc-b8e0-1a2caff9223c"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1b94eb2c-1485-4702-8459-fa450861fc91"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1f1babc9-2e7a-45ab-9c20-bd16f9c935f2"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("701d42fd-c201-4449-b890-46baaabe1d83"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b64e9472-516b-4511-9acf-f2546158a112"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("beefcbd2-6fe5-4c99-bb3b-65fbae79e1b0"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c18e24bf-50b6-4abf-a003-e9bb278ac5b2"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ce09598b-665d-4484-96d6-d7bb05162827"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0d2d6d4-4e56-4f0b-b03d-4b184ff68545"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00dbbaa4-4299-40e7-b1b0-dd850c3046fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("695390e4-5457-4636-9f3c-997c43dec926"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("779ead6f-2aa4-48be-8cfa-f9046f6c1a1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e66f455-1c50-417a-96b9-d40c8b8f916a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcb74fd2-68aa-41b7-8256-22284bf2a77c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("074e21c1-817b-4c61-b7c9-25c5d5a30df8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b72ef6e-f690-47a5-bc06-9605802f46cb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("15029935-d6e5-464b-abbe-4795c8d4dc3c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1914c2a3-7576-4e5d-a6b2-67e34c409175"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2070417c-6f79-46d4-a1ae-94143008b606"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36d87953-8e68-46f0-a588-3b90c9b5f5ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a33fddd-1e84-41de-9309-bf1993355cf2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4853ea9f-a540-4525-918c-d6e17fc00d28"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("58d53050-f2b4-4571-9f59-e171715fbb3c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b09e033-c24a-4e52-952c-9f9f8ccf06f6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("67010e44-414f-45b2-bd67-7eb12e72cc0a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7b18c1ee-0d93-4b3b-a81a-10e334d4cdd3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9ae4d9c8-0669-40d5-b5ba-2bd5fbaeb389"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3ca9d1d-e136-4f9e-8b0a-60b56cbcfaa2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("beacee74-f676-44b2-8c25-80a15b62c45e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c4991e13-d40e-4450-8ab6-3026f230e157"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c946e969-c2df-489e-9dca-65d816f7fe74"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cdf74c11-3b3e-4e4e-94d6-a82f8095bb0d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dd086a03-1e0f-444b-8be7-af6028591a71"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eab245ca-2ff0-4403-8f55-65ad2c6f0460"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f0305792-2f99-482f-86a1-e860e3236775"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f0ef1eb9-ebe1-4b75-ae88-d166f67ea470"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f125a1cc-74c0-4424-8bc6-fcab0800d602"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f9979e80-6f88-432c-81f1-47de85b1072e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("95ec868d-06aa-47c2-8ac9-74a3d4eee05d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c97fd293-eeee-4096-8385-79b83db403f8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ccf140e7-e7c2-4586-a5a0-53a1d618f7dd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f857d928-6013-4441-9ed0-6d57e15c8d3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationId",
                table: "ApplicationDocuments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("4eb2c76a-f758-4b72-96dd-1ad3778719f1"), "health care" },
                    { new Guid("4efa8bac-b3a7-430b-951d-cc547573b233"), "culture and art" },
                    { new Guid("623b8063-1bc4-4c9d-a6c9-341fcdcd2486"), "sports and physical culture" },
                    { new Guid("8ebef77a-a093-40a1-bad7-820f059070bd"), "education" },
                    { new Guid("e5197f13-5b60-4eea-8bfb-a48cca615cca"), "social programs" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"), "pl" },
                    { new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("3021e949-7883-4db6-a7f9-b2f6af961eca"), "building" },
                    { new Guid("9e12ad3c-ff8e-4766-aa64-dc779728217b"), "psychology" },
                    { new Guid("c848cfdd-7bd8-4074-a13c-1124a36fbce8"), "cooking" },
                    { new Guid("df8d22bb-6bfd-425a-816a-aa8a33d4356f"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "DescriptionCategory", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("10255ccb-f7de-4a17-894a-23c2b8d0b979"), new Guid("4eb2c76a-f758-4b72-96dd-1ad3778719f1"), " ", "en", "health care" },
                    { new Guid("36121ad4-33ac-426a-9b6f-f673fb2ff6e6"), new Guid("8ebef77a-a093-40a1-bad7-820f059070bd"), " ", "uk", "освіта" },
                    { new Guid("4b08a62f-48ed-4f99-a9bf-cb9ffae9f008"), new Guid("4eb2c76a-f758-4b72-96dd-1ad3778719f1"), " ", "uk", "охорона здоров'я" },
                    { new Guid("5bee3305-ed2b-432a-a7fa-4c32636ba0d6"), new Guid("8ebef77a-a093-40a1-bad7-820f059070bd"), " ", "en", "education" },
                    { new Guid("7d5e2130-90b5-4c38-83ef-e8a2c45b5ae9"), new Guid("623b8063-1bc4-4c9d-a6c9-341fcdcd2486"), " ", "en", "sport and physical culture" },
                    { new Guid("86251206-5729-42cb-897b-d50d194da596"), new Guid("4efa8bac-b3a7-430b-951d-cc547573b233"), " ", "uk", "культура та мистецтво" },
                    { new Guid("9a86278d-e426-4f0b-9a08-738567c86103"), new Guid("4efa8bac-b3a7-430b-951d-cc547573b233"), " ", "en", "culture and art" },
                    { new Guid("9c8757c6-7f49-4eb2-a92d-4c3f2c4e18bb"), new Guid("e5197f13-5b60-4eea-8bfb-a48cca615cca"), " ", "uk", "соціальні програми" },
                    { new Guid("a468dbdb-75ec-4d71-93b2-013eeeda1fff"), new Guid("e5197f13-5b60-4eea-8bfb-a48cca615cca"), " ", "en", "social programs" },
                    { new Guid("a68293ee-cf46-4543-a6a2-37a83f9d83ec"), new Guid("623b8063-1bc4-4c9d-a6c9-341fcdcd2486"), " ", "uk", "спорт та фізична культура" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("0f29e748-c208-404d-b10c-00c131755052"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "kher" },
                    { new Guid("176689a1-730b-42c6-9c77-24f8e7f1420c"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "my" },
                    { new Guid("1c6e3703-1675-4618-b70e-06a3d446b2a9"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "khm" },
                    { new Guid("2d2eef31-f699-4e23-8ccf-2be77d0fd99f"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "chh" },
                    { new Guid("33fe0100-68f9-4d85-8a26-b952bad87cb8"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "kr" },
                    { new Guid("4bedf628-8cf0-4a19-8e9d-101a301a45f8"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "uzh" },
                    { new Guid("51b89706-3156-4c6e-89b6-854e92f24a7c"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "chv" },
                    { new Guid("73c767bb-ffa3-4c88-8f3a-048fa6c7a816"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "lut" },
                    { new Guid("7fdd005e-3b8e-4010-b777-721d4e2971ef"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "pol" },
                    { new Guid("8048bb0e-89ed-405d-a12c-ab40daf65883"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "su" },
                    { new Guid("8112c8fb-83a9-46a6-b87e-9ce72de47712"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "zhy" },
                    { new Guid("9822f563-dab8-457e-b900-3d1f4df345a4"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "zp" },
                    { new Guid("98bae417-cf3f-4a28-a5a8-e23d79924ca3"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "dn" },
                    { new Guid("9b19acfb-5060-4970-952d-634ed4095a98"), new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"), "lub" },
                    { new Guid("a761360b-dd89-44df-8581-dc2cf6e8564d"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "ri" },
                    { new Guid("ccc7e347-e853-402a-b58f-7722469f4218"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "vi" },
                    { new Guid("d0274787-738f-4187-818b-c18d6a7356d0"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "khar" },
                    { new Guid("da263f88-5ab7-4469-be6a-1f06ec0ae463"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "od" },
                    { new Guid("de17c5bd-b05f-4694-a6d3-86a269edf80d"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "chk" },
                    { new Guid("e0a8faa5-ce02-4073-8b8d-e664768a52ad"), new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"), "var" },
                    { new Guid("e247de23-a5e1-44d7-9aa3-4a0312f7b93f"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "lv" },
                    { new Guid("e6883355-975d-4b73-bb60-083953adfb62"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "ter" },
                    { new Guid("f82616e1-a5f7-41a5-b905-8ba5a7f2a204"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "ky" },
                    { new Guid("fcf0ad22-2edb-4a7e-91a4-fb8034e54304"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "if" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("26cf99d2-11f0-411a-92b7-750456384d00"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "uk", "Україна" },
                    { new Guid("7c169287-3211-496c-a2fc-c1e4328b7958"), new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"), "uk", "Польша" },
                    { new Guid("ec382e05-3b85-4b64-8242-017ede078445"), new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"), "en", "Ukraine" },
                    { new Guid("fa89a317-0334-4d91-8474-5f44bde0aa62"), new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"), "en", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("0213d5ac-be7a-4197-b69a-e72baf4c07cd"), "uk", "будівництво", new Guid("3021e949-7883-4db6-a7f9-b2f6af961eca") },
                    { new Guid("16ee786e-a09d-4c5f-af4f-f618b065993b"), "uk", "медицина", new Guid("df8d22bb-6bfd-425a-816a-aa8a33d4356f") },
                    { new Guid("5fea66ed-8bad-4e39-a60d-c70b125c1241"), "en", "medicine", new Guid("df8d22bb-6bfd-425a-816a-aa8a33d4356f") },
                    { new Guid("6cbd7f6f-7933-4036-a7cd-4dbaa04fe870"), "en", "building", new Guid("3021e949-7883-4db6-a7f9-b2f6af961eca") }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("81f76fc1-5033-4d53-9e36-523f9fa5698c"), "en", "psychology", new Guid("9e12ad3c-ff8e-4766-aa64-dc779728217b") },
                    { new Guid("8802dd38-7055-4647-9c0d-dfc02fbe9e64"), "uk", "психологія", new Guid("9e12ad3c-ff8e-4766-aa64-dc779728217b") },
                    { new Guid("9bcce7bf-6622-4485-849c-8af13a750d88"), "en", "cooking", new Guid("c848cfdd-7bd8-4074-a13c-1124a36fbce8") },
                    { new Guid("ffca5159-5c49-4a7f-9ab7-fb9e481e28ad"), "uk", "кулінарія", new Guid("c848cfdd-7bd8-4074-a13c-1124a36fbce8") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("05b9e1a2-7d6f-40c2-b647-1a79ffc44fbc"), new Guid("da263f88-5ab7-4469-be6a-1f06ec0ae463"), "en", "Odesa" },
                    { new Guid("061ce734-c7db-40cd-b6db-4e48c98bdef9"), new Guid("98bae417-cf3f-4a28-a5a8-e23d79924ca3"), "en", "Dnipro" },
                    { new Guid("0a85b128-0ad2-4b10-8af0-6804216efbb6"), new Guid("8112c8fb-83a9-46a6-b87e-9ce72de47712"), "uk", "Житомир" },
                    { new Guid("0bad1e09-c15a-468e-b927-f2fdc1c6a635"), new Guid("33fe0100-68f9-4d85-8a26-b952bad87cb8"), "uk", "Кропивницький" },
                    { new Guid("0f6ff792-a459-4f7a-97ee-8c4f423a07c9"), new Guid("ccc7e347-e853-402a-b58f-7722469f4218"), "en", "Vinnytsia" },
                    { new Guid("15cb5f03-d67a-4658-8a04-cf7c9e9b86b4"), new Guid("d0274787-738f-4187-818b-c18d6a7356d0"), "en", "Kharkiv" },
                    { new Guid("1efa4eb1-eae0-4e57-bc20-997154854f23"), new Guid("e247de23-a5e1-44d7-9aa3-4a0312f7b93f"), "uk", "Львів" },
                    { new Guid("21a84d1f-de3f-4038-8e7b-966c468c9baa"), new Guid("73c767bb-ffa3-4c88-8f3a-048fa6c7a816"), "uk", "Луцьк" },
                    { new Guid("225ddf58-7dc9-41e5-b96f-0a8cdd29e4c8"), new Guid("7fdd005e-3b8e-4010-b777-721d4e2971ef"), "uk", "Полтава" },
                    { new Guid("24d6b709-58a9-4759-9bc2-a8db08661cc3"), new Guid("a761360b-dd89-44df-8581-dc2cf6e8564d"), "en", "Rivne" },
                    { new Guid("320a36c7-a276-4411-825d-210459c7ffa0"), new Guid("33fe0100-68f9-4d85-8a26-b952bad87cb8"), "en", "Kropyvnytskyi" },
                    { new Guid("43d01c28-3b87-48b9-b70a-8cf9900abe78"), new Guid("73c767bb-ffa3-4c88-8f3a-048fa6c7a816"), "en", "Lutsk" },
                    { new Guid("48ac5f17-a3e9-4d3f-b236-8a41a74cb857"), new Guid("2d2eef31-f699-4e23-8ccf-2be77d0fd99f"), "en", "Chernihiv" },
                    { new Guid("5261a3bc-796d-4d58-bc0b-6d16e26769a2"), new Guid("4bedf628-8cf0-4a19-8e9d-101a301a45f8"), "uk", "Ужгород" },
                    { new Guid("55e81311-fd3a-4d65-b317-6ba2f681e884"), new Guid("2d2eef31-f699-4e23-8ccf-2be77d0fd99f"), "uk", "Чернігів" },
                    { new Guid("5ae35996-0082-41f3-afdc-f3519791a8af"), new Guid("0f29e748-c208-404d-b10c-00c131755052"), "en", "Kherson" },
                    { new Guid("5b5cf6c8-e328-4db9-a4e5-17b34cd83bc6"), new Guid("f82616e1-a5f7-41a5-b905-8ba5a7f2a204"), "en", "Kyiv" },
                    { new Guid("5d656e9e-65bd-4725-bf78-c403be1918a3"), new Guid("8048bb0e-89ed-405d-a12c-ab40daf65883"), "uk", "Суми" },
                    { new Guid("6667df2b-33f7-4f40-85bd-be2942a84336"), new Guid("e0a8faa5-ce02-4073-8b8d-e664768a52ad"), "en", "Varshava" },
                    { new Guid("79376a18-a842-4252-b598-9b59f245fff3"), new Guid("e6883355-975d-4b73-bb60-083953adfb62"), "en", "Ternopil" },
                    { new Guid("80af9335-f5b9-426a-8246-1e931a2d8f9e"), new Guid("9822f563-dab8-457e-b900-3d1f4df345a4"), "uk", "Запоріжжя" },
                    { new Guid("8499a271-dea8-4e5a-8c3e-e2a69129cd1c"), new Guid("fcf0ad22-2edb-4a7e-91a4-fb8034e54304"), "uk", "Івано-Франківськ" },
                    { new Guid("849cf436-3289-492e-9a9a-258949e504e3"), new Guid("da263f88-5ab7-4469-be6a-1f06ec0ae463"), "uk", "Одеса" },
                    { new Guid("8cc2610c-1722-41a0-b818-22bd1344072b"), new Guid("7fdd005e-3b8e-4010-b777-721d4e2971ef"), "en", "Poltava" },
                    { new Guid("929bc386-e20d-400c-8b74-473f961c4757"), new Guid("de17c5bd-b05f-4694-a6d3-86a269edf80d"), "en", "Cherkasy" },
                    { new Guid("97770636-9f15-4259-8dd0-e28c6c7d892e"), new Guid("de17c5bd-b05f-4694-a6d3-86a269edf80d"), "uk", "Черкаси" },
                    { new Guid("9e3df9e9-7c0c-4a58-860b-d63c1b9452b0"), new Guid("176689a1-730b-42c6-9c77-24f8e7f1420c"), "en", "Mykolaiv" },
                    { new Guid("9ed3bc29-c761-48f5-945e-52ecab4976df"), new Guid("51b89706-3156-4c6e-89b6-854e92f24a7c"), "en", "Chernivtsi" },
                    { new Guid("a13a992d-1802-4448-94e7-2d5a5f195060"), new Guid("fcf0ad22-2edb-4a7e-91a4-fb8034e54304"), "en", "Ivano-Frankivsk" },
                    { new Guid("a60c3d85-0375-42e5-80f9-21660cd85cc7"), new Guid("e6883355-975d-4b73-bb60-083953adfb62"), "uk", "Тернопіль" },
                    { new Guid("a8d3aead-c55e-4e24-9298-95015bc648ab"), new Guid("1c6e3703-1675-4618-b70e-06a3d446b2a9"), "uk", "Хмельницький" },
                    { new Guid("a9de1d94-b82d-4970-9876-9770a664d4bb"), new Guid("9822f563-dab8-457e-b900-3d1f4df345a4"), "en", "Zaporizhzhia" },
                    { new Guid("af77365c-8832-474d-85de-e050f2d434e9"), new Guid("4bedf628-8cf0-4a19-8e9d-101a301a45f8"), "en", "Uzhhorod" },
                    { new Guid("afece68a-6cc5-4949-ae9e-01747b9f1f9e"), new Guid("ccc7e347-e853-402a-b58f-7722469f4218"), "uk", "Вінниця" },
                    { new Guid("b00ef915-95e3-410f-999b-430222fefd29"), new Guid("8048bb0e-89ed-405d-a12c-ab40daf65883"), "en", "Sumy" },
                    { new Guid("b14d9e56-8031-421b-b0db-876b0be5eb95"), new Guid("a761360b-dd89-44df-8581-dc2cf6e8564d"), "uk", "Рівне" },
                    { new Guid("b39aca12-4941-4fc3-b6c5-3588af5d0a31"), new Guid("0f29e748-c208-404d-b10c-00c131755052"), "uk", "Херсон" },
                    { new Guid("b790457a-d2f4-4b32-aac3-93b2fddeb677"), new Guid("98bae417-cf3f-4a28-a5a8-e23d79924ca3"), "uk", "Дніпро" },
                    { new Guid("c69d2957-f6c8-49f0-8912-981ade79715c"), new Guid("e247de23-a5e1-44d7-9aa3-4a0312f7b93f"), "en", "Lviv" },
                    { new Guid("cc689697-924d-40b2-95c3-bc0033c9dedd"), new Guid("f82616e1-a5f7-41a5-b905-8ba5a7f2a204"), "uk", "Київ" },
                    { new Guid("cefd57c4-5ab8-408d-abcd-e7b794d70f28"), new Guid("176689a1-730b-42c6-9c77-24f8e7f1420c"), "uk", "Миколаїв" },
                    { new Guid("d085f561-78a4-4140-9367-f6eb08bdf4a5"), new Guid("9b19acfb-5060-4970-952d-634ed4095a98"), "uk", "Люблін" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d7277544-cb3b-4e89-9bb6-cb663e3fe917"), new Guid("9b19acfb-5060-4970-952d-634ed4095a98"), "en", "Lublin" },
                    { new Guid("dfb5fa9d-f241-4236-af57-1ad90f68da2c"), new Guid("8112c8fb-83a9-46a6-b87e-9ce72de47712"), "en", "Zhytomyr" },
                    { new Guid("e1a64a39-4716-47eb-ac41-cd0196403bfd"), new Guid("e0a8faa5-ce02-4073-8b8d-e664768a52ad"), "uk", "Варшава" },
                    { new Guid("e3457f96-590b-4d49-a572-da528d3c3379"), new Guid("d0274787-738f-4187-818b-c18d6a7356d0"), "uk", "Харків" },
                    { new Guid("f1c48b31-6183-48bc-a55d-2f74ea81dc4d"), new Guid("51b89706-3156-4c6e-89b6-854e92f24a7c"), "uk", "Чернівці" },
                    { new Guid("fbcd37fd-94eb-4357-8c2b-7652e3b7641d"), new Guid("1c6e3703-1675-4618-b70e-06a3d446b2a9"), "en", "Khmelnytskyi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("7c8b2f83-ffb4-46b7-bea6-38716ad880ac"), new Guid("ccc7e347-e853-402a-b58f-7722469f4218"), new DateTime(2023, 5, 25, 16, 8, 53, 499, DateTimeKind.Local).AddTicks(2040), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationDocuments_Applications_ApplicationId",
                table: "ApplicationDocuments",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationDocuments_Applications_ApplicationId",
                table: "ApplicationDocuments");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("10255ccb-f7de-4a17-894a-23c2b8d0b979"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("36121ad4-33ac-426a-9b6f-f673fb2ff6e6"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4b08a62f-48ed-4f99-a9bf-cb9ffae9f008"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5bee3305-ed2b-432a-a7fa-4c32636ba0d6"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7d5e2130-90b5-4c38-83ef-e8a2c45b5ae9"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("86251206-5729-42cb-897b-d50d194da596"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9a86278d-e426-4f0b-9a08-738567c86103"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9c8757c6-7f49-4eb2-a92d-4c3f2c4e18bb"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a468dbdb-75ec-4d71-93b2-013eeeda1fff"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a68293ee-cf46-4543-a6a2-37a83f9d83ec"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("05b9e1a2-7d6f-40c2-b647-1a79ffc44fbc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("061ce734-c7db-40cd-b6db-4e48c98bdef9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0a85b128-0ad2-4b10-8af0-6804216efbb6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0bad1e09-c15a-468e-b927-f2fdc1c6a635"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0f6ff792-a459-4f7a-97ee-8c4f423a07c9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("15cb5f03-d67a-4658-8a04-cf7c9e9b86b4"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1efa4eb1-eae0-4e57-bc20-997154854f23"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("21a84d1f-de3f-4038-8e7b-966c468c9baa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("225ddf58-7dc9-41e5-b96f-0a8cdd29e4c8"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("24d6b709-58a9-4759-9bc2-a8db08661cc3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("320a36c7-a276-4411-825d-210459c7ffa0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("43d01c28-3b87-48b9-b70a-8cf9900abe78"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("48ac5f17-a3e9-4d3f-b236-8a41a74cb857"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5261a3bc-796d-4d58-bc0b-6d16e26769a2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("55e81311-fd3a-4d65-b317-6ba2f681e884"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5ae35996-0082-41f3-afdc-f3519791a8af"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5b5cf6c8-e328-4db9-a4e5-17b34cd83bc6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5d656e9e-65bd-4725-bf78-c403be1918a3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6667df2b-33f7-4f40-85bd-be2942a84336"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("79376a18-a842-4252-b598-9b59f245fff3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("80af9335-f5b9-426a-8246-1e931a2d8f9e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8499a271-dea8-4e5a-8c3e-e2a69129cd1c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("849cf436-3289-492e-9a9a-258949e504e3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8cc2610c-1722-41a0-b818-22bd1344072b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("929bc386-e20d-400c-8b74-473f961c4757"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("97770636-9f15-4259-8dd0-e28c6c7d892e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9e3df9e9-7c0c-4a58-860b-d63c1b9452b0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9ed3bc29-c761-48f5-945e-52ecab4976df"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a13a992d-1802-4448-94e7-2d5a5f195060"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a60c3d85-0375-42e5-80f9-21660cd85cc7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a8d3aead-c55e-4e24-9298-95015bc648ab"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a9de1d94-b82d-4970-9876-9770a664d4bb"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("af77365c-8832-474d-85de-e050f2d434e9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("afece68a-6cc5-4949-ae9e-01747b9f1f9e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b00ef915-95e3-410f-999b-430222fefd29"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b14d9e56-8031-421b-b0db-876b0be5eb95"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b39aca12-4941-4fc3-b6c5-3588af5d0a31"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b790457a-d2f4-4b32-aac3-93b2fddeb677"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c69d2957-f6c8-49f0-8912-981ade79715c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cc689697-924d-40b2-95c3-bc0033c9dedd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cefd57c4-5ab8-408d-abcd-e7b794d70f28"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d085f561-78a4-4140-9367-f6eb08bdf4a5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d7277544-cb3b-4e89-9bb6-cb663e3fe917"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dfb5fa9d-f241-4236-af57-1ad90f68da2c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e1a64a39-4716-47eb-ac41-cd0196403bfd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e3457f96-590b-4d49-a572-da528d3c3379"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f1c48b31-6183-48bc-a55d-2f74ea81dc4d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fbcd37fd-94eb-4357-8c2b-7652e3b7641d"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("26cf99d2-11f0-411a-92b7-750456384d00"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7c169287-3211-496c-a2fc-c1e4328b7958"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ec382e05-3b85-4b64-8242-017ede078445"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fa89a317-0334-4d91-8474-5f44bde0aa62"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0213d5ac-be7a-4197-b69a-e72baf4c07cd"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("16ee786e-a09d-4c5f-af4f-f618b065993b"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5fea66ed-8bad-4e39-a60d-c70b125c1241"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6cbd7f6f-7933-4036-a7cd-4dbaa04fe870"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("81f76fc1-5033-4d53-9e36-523f9fa5698c"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8802dd38-7055-4647-9c0d-dfc02fbe9e64"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9bcce7bf-6622-4485-849c-8af13a750d88"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ffca5159-5c49-4a7f-9ab7-fb9e481e28ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c8b2f83-ffb4-46b7-bea6-38716ad880ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4eb2c76a-f758-4b72-96dd-1ad3778719f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4efa8bac-b3a7-430b-951d-cc547573b233"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("623b8063-1bc4-4c9d-a6c9-341fcdcd2486"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ebef77a-a093-40a1-bad7-820f059070bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5197f13-5b60-4eea-8bfb-a48cca615cca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0f29e748-c208-404d-b10c-00c131755052"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("176689a1-730b-42c6-9c77-24f8e7f1420c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c6e3703-1675-4618-b70e-06a3d446b2a9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d2eef31-f699-4e23-8ccf-2be77d0fd99f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("33fe0100-68f9-4d85-8a26-b952bad87cb8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4bedf628-8cf0-4a19-8e9d-101a301a45f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("51b89706-3156-4c6e-89b6-854e92f24a7c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73c767bb-ffa3-4c88-8f3a-048fa6c7a816"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fdd005e-3b8e-4010-b777-721d4e2971ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8048bb0e-89ed-405d-a12c-ab40daf65883"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8112c8fb-83a9-46a6-b87e-9ce72de47712"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9822f563-dab8-457e-b900-3d1f4df345a4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("98bae417-cf3f-4a28-a5a8-e23d79924ca3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9b19acfb-5060-4970-952d-634ed4095a98"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a761360b-dd89-44df-8581-dc2cf6e8564d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ccc7e347-e853-402a-b58f-7722469f4218"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d0274787-738f-4187-818b-c18d6a7356d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("da263f88-5ab7-4469-be6a-1f06ec0ae463"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("de17c5bd-b05f-4694-a6d3-86a269edf80d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0a8faa5-ce02-4073-8b8d-e664768a52ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e247de23-a5e1-44d7-9aa3-4a0312f7b93f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e6883355-975d-4b73-bb60-083953adfb62"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f82616e1-a5f7-41a5-b905-8ba5a7f2a204"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fcf0ad22-2edb-4a7e-91a4-fb8034e54304"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3021e949-7883-4db6-a7f9-b2f6af961eca"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9e12ad3c-ff8e-4766-aa64-dc779728217b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c848cfdd-7bd8-4074-a13c-1124a36fbce8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("df8d22bb-6bfd-425a-816a-aa8a33d4356f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("926df0da-9404-412b-9fee-3b2a0d3939f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95c93c40-9a93-4b6c-af60-c27f34750cae"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationId",
                table: "ApplicationDocuments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("00dbbaa4-4299-40e7-b1b0-dd850c3046fb"), "education" },
                    { new Guid("695390e4-5457-4636-9f3c-997c43dec926"), "health care" },
                    { new Guid("779ead6f-2aa4-48be-8cfa-f9046f6c1a1a"), "social programs" },
                    { new Guid("7e66f455-1c50-417a-96b9-d40c8b8f916a"), "sports and physical culture" },
                    { new Guid("dcb74fd2-68aa-41b7-8256-22284bf2a77c"), "culture and art" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"), "pl" },
                    { new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("95ec868d-06aa-47c2-8ac9-74a3d4eee05d"), "psychology" },
                    { new Guid("c97fd293-eeee-4096-8385-79b83db403f8"), "cooking" },
                    { new Guid("ccf140e7-e7c2-4586-a5a0-53a1d618f7dd"), "building" },
                    { new Guid("f857d928-6013-4441-9ed0-6d57e15c8d3e"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "DescriptionCategory", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("03e1fd94-ec43-481a-915e-431f1f60ee9d"), new Guid("00dbbaa4-4299-40e7-b1b0-dd850c3046fb"), " ", "en", "education" },
                    { new Guid("147e633e-6c29-4484-9230-a054f984d06a"), new Guid("779ead6f-2aa4-48be-8cfa-f9046f6c1a1a"), " ", "en", "social programs" },
                    { new Guid("67a55bc8-f684-40d3-ae91-5ba26d25ec1f"), new Guid("695390e4-5457-4636-9f3c-997c43dec926"), " ", "uk", "охорона здоров'я" },
                    { new Guid("7d07ef65-6ce8-41e4-b249-b578d9c5057d"), new Guid("779ead6f-2aa4-48be-8cfa-f9046f6c1a1a"), " ", "uk", "соціальні програми" },
                    { new Guid("84216b51-84aa-4ce8-b2fe-8c4426883615"), new Guid("7e66f455-1c50-417a-96b9-d40c8b8f916a"), " ", "en", "sport and physical culture" },
                    { new Guid("958602e1-bd60-4cb8-b541-00dafe3bf086"), new Guid("695390e4-5457-4636-9f3c-997c43dec926"), " ", "en", "health care" },
                    { new Guid("99a9bcf6-26a3-4782-86a6-0b767a954250"), new Guid("7e66f455-1c50-417a-96b9-d40c8b8f916a"), " ", "uk", "спорт та фізична культура" },
                    { new Guid("b456e736-4a33-4e4e-bb83-3cadb7fec609"), new Guid("00dbbaa4-4299-40e7-b1b0-dd850c3046fb"), " ", "uk", "освіта" },
                    { new Guid("e23da740-8efe-42bd-a45b-e416265df134"), new Guid("dcb74fd2-68aa-41b7-8256-22284bf2a77c"), " ", "en", "culture and art" },
                    { new Guid("f4c05e1a-bc7c-4c20-b921-03f330c5eafb"), new Guid("dcb74fd2-68aa-41b7-8256-22284bf2a77c"), " ", "uk", "культура та мистецтво" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("074e21c1-817b-4c61-b7c9-25c5d5a30df8"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "lut" },
                    { new Guid("0b72ef6e-f690-47a5-bc06-9605802f46cb"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "ky" },
                    { new Guid("15029935-d6e5-464b-abbe-4795c8d4dc3c"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "su" },
                    { new Guid("1914c2a3-7576-4e5d-a6b2-67e34c409175"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "chh" },
                    { new Guid("2070417c-6f79-46d4-a1ae-94143008b606"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "kr" },
                    { new Guid("36d87953-8e68-46f0-a588-3b90c9b5f5ce"), new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"), "lub" },
                    { new Guid("3a33fddd-1e84-41de-9309-bf1993355cf2"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "zhy" },
                    { new Guid("4853ea9f-a540-4525-918c-d6e17fc00d28"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "ter" },
                    { new Guid("58d53050-f2b4-4571-9f59-e171715fbb3c"), new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"), "var" },
                    { new Guid("5b09e033-c24a-4e52-952c-9f9f8ccf06f6"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "khm" },
                    { new Guid("67010e44-414f-45b2-bd67-7eb12e72cc0a"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "pol" },
                    { new Guid("7b18c1ee-0d93-4b3b-a81a-10e334d4cdd3"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "od" },
                    { new Guid("9ae4d9c8-0669-40d5-b5ba-2bd5fbaeb389"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "lv" },
                    { new Guid("b3ca9d1d-e136-4f9e-8b0a-60b56cbcfaa2"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "khar" },
                    { new Guid("beacee74-f676-44b2-8c25-80a15b62c45e"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "dn" },
                    { new Guid("c4991e13-d40e-4450-8ab6-3026f230e157"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "vi" },
                    { new Guid("c946e969-c2df-489e-9dca-65d816f7fe74"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "zp" },
                    { new Guid("cdf74c11-3b3e-4e4e-94d6-a82f8095bb0d"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "if" },
                    { new Guid("dd086a03-1e0f-444b-8be7-af6028591a71"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "chk" },
                    { new Guid("eab245ca-2ff0-4403-8f55-65ad2c6f0460"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "ri" },
                    { new Guid("f0305792-2f99-482f-86a1-e860e3236775"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "my" },
                    { new Guid("f0ef1eb9-ebe1-4b75-ae88-d166f67ea470"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "chv" },
                    { new Guid("f125a1cc-74c0-4424-8bc6-fcab0800d602"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "kher" },
                    { new Guid("f9979e80-6f88-432c-81f1-47de85b1072e"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "uzh" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("1dac11b7-1aca-4f70-b1ca-4e18e3919885"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "uk", "Україна" },
                    { new Guid("ab91f884-8b1e-4b98-9caa-6a2eb154fc91"), new Guid("a637ea86-fae4-47a3-ad96-d9e630225423"), "en", "Ukraine" },
                    { new Guid("ba0c5939-fa38-431a-aa96-c403bf6eb956"), new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"), "en", "Poland" },
                    { new Guid("ff90ee03-f699-499a-bf4c-73f79e7ceac6"), new Guid("1c05835f-b417-4bda-8a51-8b6fc740ef47"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("1a066b47-09d1-46fc-b8e0-1a2caff9223c"), "uk", "будівництво", new Guid("ccf140e7-e7c2-4586-a5a0-53a1d618f7dd") },
                    { new Guid("1b94eb2c-1485-4702-8459-fa450861fc91"), "uk", "психологія", new Guid("95ec868d-06aa-47c2-8ac9-74a3d4eee05d") },
                    { new Guid("1f1babc9-2e7a-45ab-9c20-bd16f9c935f2"), "uk", "медицина", new Guid("f857d928-6013-4441-9ed0-6d57e15c8d3e") },
                    { new Guid("701d42fd-c201-4449-b890-46baaabe1d83"), "en", "medicine", new Guid("f857d928-6013-4441-9ed0-6d57e15c8d3e") }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("b64e9472-516b-4511-9acf-f2546158a112"), "en", "psychology", new Guid("95ec868d-06aa-47c2-8ac9-74a3d4eee05d") },
                    { new Guid("beefcbd2-6fe5-4c99-bb3b-65fbae79e1b0"), "en", "building", new Guid("ccf140e7-e7c2-4586-a5a0-53a1d618f7dd") },
                    { new Guid("c18e24bf-50b6-4abf-a003-e9bb278ac5b2"), "en", "cooking", new Guid("c97fd293-eeee-4096-8385-79b83db403f8") },
                    { new Guid("ce09598b-665d-4484-96d6-d7bb05162827"), "uk", "кулінарія", new Guid("c97fd293-eeee-4096-8385-79b83db403f8") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("01f39cc1-9917-4719-a9f1-c19c5581fe60"), new Guid("074e21c1-817b-4c61-b7c9-25c5d5a30df8"), "uk", "Луцьк" },
                    { new Guid("03813f27-a0a5-4c65-b0c2-45dedc212a06"), new Guid("36d87953-8e68-46f0-a588-3b90c9b5f5ce"), "en", "Lublin" },
                    { new Guid("03b11763-bbfa-4383-b443-9504f7efe64a"), new Guid("4853ea9f-a540-4525-918c-d6e17fc00d28"), "en", "Ternopil" },
                    { new Guid("048133cc-2327-4c4f-ba59-b4b768415802"), new Guid("5b09e033-c24a-4e52-952c-9f9f8ccf06f6"), "uk", "Хмельницький" },
                    { new Guid("04cb560e-c607-4efc-877d-340dfde24e03"), new Guid("b3ca9d1d-e136-4f9e-8b0a-60b56cbcfaa2"), "en", "Kharkiv" },
                    { new Guid("0d75d80d-20bb-49a4-9a61-2a9d75d26079"), new Guid("2070417c-6f79-46d4-a1ae-94143008b606"), "en", "Kropyvnytskyi" },
                    { new Guid("1909f673-cf97-4181-9bc7-7029baffc64a"), new Guid("074e21c1-817b-4c61-b7c9-25c5d5a30df8"), "en", "Lutsk" },
                    { new Guid("1bbf210e-3e1b-4f19-b8dd-dc2e7b04b62f"), new Guid("9ae4d9c8-0669-40d5-b5ba-2bd5fbaeb389"), "uk", "Львів" },
                    { new Guid("1ebb665d-8468-46e0-890c-3ccdc63ae881"), new Guid("0b72ef6e-f690-47a5-bc06-9605802f46cb"), "en", "Kyiv" },
                    { new Guid("28078ac8-a640-459a-b6fd-c93819ab90c5"), new Guid("67010e44-414f-45b2-bd67-7eb12e72cc0a"), "en", "Poltava" },
                    { new Guid("34662c56-e820-4ac2-86d4-2a493a0ed902"), new Guid("beacee74-f676-44b2-8c25-80a15b62c45e"), "en", "Dnipro" },
                    { new Guid("39088edb-1e80-448f-a805-404978e37548"), new Guid("1914c2a3-7576-4e5d-a6b2-67e34c409175"), "uk", "Чернігів" },
                    { new Guid("3dfb147f-f486-4790-baab-09df76ce0f5c"), new Guid("dd086a03-1e0f-444b-8be7-af6028591a71"), "uk", "Черкаси" },
                    { new Guid("3f7e5538-25f7-4a8f-98bc-f07ba702338c"), new Guid("f0305792-2f99-482f-86a1-e860e3236775"), "uk", "Миколаїв" },
                    { new Guid("3ff23279-4ada-4448-90ca-8ff31f458b7c"), new Guid("15029935-d6e5-464b-abbe-4795c8d4dc3c"), "uk", "Суми" },
                    { new Guid("40b1dbc4-c5e1-465a-9273-c922c4e29a5d"), new Guid("eab245ca-2ff0-4403-8f55-65ad2c6f0460"), "en", "Rivne" },
                    { new Guid("4101f4a4-c93b-4538-b852-6e7c1a6fc8c5"), new Guid("c946e969-c2df-489e-9dca-65d816f7fe74"), "uk", "Запоріжжя" },
                    { new Guid("49dd8861-f844-4aa3-bea6-6aa7365cc8dd"), new Guid("f0305792-2f99-482f-86a1-e860e3236775"), "en", "Mykolaiv" },
                    { new Guid("4a787f71-5f88-41e3-ad52-7eef108afafc"), new Guid("eab245ca-2ff0-4403-8f55-65ad2c6f0460"), "uk", "Рівне" },
                    { new Guid("4ea83fb3-d1eb-4c91-96fd-408e2f1fd269"), new Guid("4853ea9f-a540-4525-918c-d6e17fc00d28"), "uk", "Тернопіль" },
                    { new Guid("55913e4e-90a4-40eb-ae0a-1bbb97697e29"), new Guid("f9979e80-6f88-432c-81f1-47de85b1072e"), "en", "Uzhhorod" },
                    { new Guid("55fd5c22-84b4-4ae3-a350-8eb2f51a7ab9"), new Guid("7b18c1ee-0d93-4b3b-a81a-10e334d4cdd3"), "en", "Odesa" },
                    { new Guid("57945bd6-5a43-4832-b822-09bf9e67cdb7"), new Guid("cdf74c11-3b3e-4e4e-94d6-a82f8095bb0d"), "uk", "Івано-Франківськ" },
                    { new Guid("688c2654-3705-4ca9-b927-bf5240bc350b"), new Guid("beacee74-f676-44b2-8c25-80a15b62c45e"), "uk", "Дніпро" },
                    { new Guid("68d38896-4d6d-4a45-8166-8d807a7b0a26"), new Guid("c946e969-c2df-489e-9dca-65d816f7fe74"), "en", "Zaporizhzhia" },
                    { new Guid("6a060bfe-1962-4794-971b-cea8def720ad"), new Guid("c4991e13-d40e-4450-8ab6-3026f230e157"), "uk", "Вінниця" },
                    { new Guid("6a428be9-f4f2-46b4-b3bd-83779483f425"), new Guid("f9979e80-6f88-432c-81f1-47de85b1072e"), "uk", "Ужгород" },
                    { new Guid("6b93a13d-2ccf-4676-b4cf-700d69b153d7"), new Guid("15029935-d6e5-464b-abbe-4795c8d4dc3c"), "en", "Sumy" },
                    { new Guid("756ef16d-d73d-4e16-93bf-9a20ad56661e"), new Guid("f125a1cc-74c0-4424-8bc6-fcab0800d602"), "uk", "Херсон" },
                    { new Guid("8380a125-8dcb-404a-8c61-ff874128d3ff"), new Guid("f0ef1eb9-ebe1-4b75-ae88-d166f67ea470"), "en", "Chernivtsi" },
                    { new Guid("957737dd-267b-45c5-8214-d61986816862"), new Guid("67010e44-414f-45b2-bd67-7eb12e72cc0a"), "uk", "Полтава" },
                    { new Guid("9d764410-1546-448b-a09f-f38feebf8ec6"), new Guid("0b72ef6e-f690-47a5-bc06-9605802f46cb"), "uk", "Київ" },
                    { new Guid("b179d4a9-2dab-420c-9e13-6857e6cde433"), new Guid("7b18c1ee-0d93-4b3b-a81a-10e334d4cdd3"), "uk", "Одеса" },
                    { new Guid("b7d85eee-18b9-40bc-8bf7-760ad7a3f97e"), new Guid("58d53050-f2b4-4571-9f59-e171715fbb3c"), "en", "Varshava" },
                    { new Guid("c209d18a-5435-4700-ba95-7b08b65be6bc"), new Guid("36d87953-8e68-46f0-a588-3b90c9b5f5ce"), "uk", "Люблін" },
                    { new Guid("cb3f4efb-d455-49c5-b20d-7c38a9a76a26"), new Guid("cdf74c11-3b3e-4e4e-94d6-a82f8095bb0d"), "en", "Ivano-Frankivsk" },
                    { new Guid("d4d14e1a-d24e-4e1f-aad8-c24555fb0f08"), new Guid("f125a1cc-74c0-4424-8bc6-fcab0800d602"), "en", "Kherson" },
                    { new Guid("d528d578-27fb-488b-a231-90cf2b6200b0"), new Guid("dd086a03-1e0f-444b-8be7-af6028591a71"), "en", "Cherkasy" },
                    { new Guid("d5f34dc3-d9f7-4731-9339-aa92d674a209"), new Guid("5b09e033-c24a-4e52-952c-9f9f8ccf06f6"), "en", "Khmelnytskyi" },
                    { new Guid("ddd7d3c6-4846-42ab-833e-21d1b619712b"), new Guid("2070417c-6f79-46d4-a1ae-94143008b606"), "uk", "Кропивницький" },
                    { new Guid("df476c59-8e07-43fd-9d39-7daf828d159e"), new Guid("3a33fddd-1e84-41de-9309-bf1993355cf2"), "en", "Zhytomyr" },
                    { new Guid("dfa539f8-7362-458c-89d5-8d7050738159"), new Guid("c4991e13-d40e-4450-8ab6-3026f230e157"), "en", "Vinnytsia" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("e8985247-f3f4-4a03-939a-7ed0c842b2a5"), new Guid("3a33fddd-1e84-41de-9309-bf1993355cf2"), "uk", "Житомир" },
                    { new Guid("ed279664-7198-4051-9d75-e7711f9459c7"), new Guid("b3ca9d1d-e136-4f9e-8b0a-60b56cbcfaa2"), "uk", "Харків" },
                    { new Guid("ed4e3f5f-ea94-4f33-999b-bc614774a9c5"), new Guid("f0ef1eb9-ebe1-4b75-ae88-d166f67ea470"), "uk", "Чернівці" },
                    { new Guid("edfbefca-f0f1-4a4f-a063-479e38d36fd7"), new Guid("1914c2a3-7576-4e5d-a6b2-67e34c409175"), "en", "Chernihiv" },
                    { new Guid("f0a97eab-5281-49c0-a165-645ffadd540d"), new Guid("58d53050-f2b4-4571-9f59-e171715fbb3c"), "uk", "Варшава" },
                    { new Guid("fc849a5f-76c8-4e2a-9834-c4777ac45965"), new Guid("9ae4d9c8-0669-40d5-b5ba-2bd5fbaeb389"), "en", "Lviv" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("a0d2d6d4-4e56-4f0b-b03d-4b184ff68545"), new Guid("c4991e13-d40e-4450-8ab6-3026f230e157"), new DateTime(2023, 5, 25, 15, 58, 5, 390, DateTimeKind.Local).AddTicks(4233), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationDocuments_Applications_ApplicationId",
                table: "ApplicationDocuments",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");
        }
    }
}

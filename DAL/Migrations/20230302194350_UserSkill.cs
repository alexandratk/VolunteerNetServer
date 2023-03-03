using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class UserSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_Skills_SkillId",
                table: "UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_Users_UserId",
                table: "UserSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill");

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0da1d5bb-6d9c-4127-84d0-fe23aa55d414"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1fcfee7c-522c-486c-a6d6-8211df6aa9a1"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("201eebdc-2c7c-4b3c-9b9e-06f1fb8d8984"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2ac8cc26-0439-40c1-a327-74466dbb378c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2df58756-4435-446b-86fb-c0aa79eac53e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("34494f1c-b65c-42f1-84f8-358057fa0abc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("357d3bc8-1f9c-4062-b685-ab0bcd9aed78"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("36fb0298-89fb-442e-a5d2-06b037d357a3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3f0eaac8-c4b7-46d7-a2e1-3b3f9ff6b941"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4031cbec-e585-489c-ae6c-fe22e2a81602"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("40d433fc-f568-4406-9c0e-3ecacc40c9e3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("41f2dae9-302b-4ed8-b106-e80b0cb7006c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("42cca5d2-5a9e-4f75-a7c4-932da19c2a00"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("47fb25ec-1cb8-4257-b19e-4ea6a5e410a6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5a0cdbbb-f5a3-4e0f-96e0-71748b6b138e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5aa122a2-329b-49ce-bfd9-04f1286f5a35"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5d5da4b6-b341-4e1a-8974-7041b4b83a20"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("64baff49-073b-4cb1-acca-3f747d7cf198"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("68a572be-fea9-4c27-86c7-749c4afd694d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("69dac06e-fa38-4ec3-b5aa-3b501b552ed3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6e54d645-38fb-4eb9-a58c-d9029aa47702"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6fdcdcbe-24a4-4795-b538-7baa3159abb8"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("76d31c2e-5688-4751-b012-7ba3e37fd32c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7736a5be-0c00-4889-8b08-0dcf3dde3dce"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("78644915-50e7-4bd7-b48a-f92944d1d22e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7c60fc11-39b9-47f8-aa54-fd037fb0db89"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("88bfdea0-2239-45e6-b4d1-be2e55f2f4ff"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("93737d70-b818-4eea-9b12-b0317e68f3ae"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("96d2ec16-795b-443e-bc65-6366d51bea96"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("97e46c75-1867-4772-b344-18a5cb65d002"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9d27be89-1964-446c-8cc6-2e1013a48d7c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9e92e71b-4dae-4361-9aca-5cac0f5bf48f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a765ff8f-f643-40b0-ab0e-223345a91206"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("acf0b1e9-5535-446e-8f99-651990c207c0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c2f3cb62-a285-45cd-bcf0-49410168fa25"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c4e9906e-7de4-4b28-85d8-66179abda67e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c73167ad-6539-4a71-95e0-a55164377c32"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c813c9d6-f2b1-4f2a-aed1-d6b74641a666"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d9238879-7cee-4f44-b30d-bb2e1f178e04"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f24fe0a0-7f2a-4188-8aae-3a8624d25afd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f2bcec47-f729-4565-822b-e617aef3b44a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f3f52cc4-d49c-4d08-bc1e-242352343683"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f7e8c205-093f-405f-9c02-8b91c81f8e93"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f919ce55-ac08-4a3b-9805-0c8341e1be7a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fb024c72-95ea-4862-adc3-9a0e91891bd8"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fbbc585a-c8d3-41e8-af04-8597d96a73dd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fe4b045c-5d5e-426c-a464-39b7f3f1729a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ff2e1834-5e30-44bb-938f-a9e0049c738c"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("464be5bc-5e2f-4470-a41d-e7e462c5645d"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("535bc928-2bfe-4c2f-bcb2-c3080f2d6395"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6ec95273-8479-4ebe-aa2b-6986c98dc89e"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e72569c6-bc9b-4f27-9180-86ab0c4d09d1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("83b648e6-86fb-4aec-ab72-df2d87f47b4f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e1fd7138-bf1a-41bd-9961-27439c4ade44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94fd4913-c866-42d2-83aa-053e99946b25"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("012b8f73-37db-4bbd-9dff-301a14cd9784"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("01525635-6fbb-4635-a0a1-0bfa0562f01e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("04de4d25-9326-4bf2-a193-75d4670198c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0fada013-f8ac-42bc-b88f-e34338f2fd6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2ff7f6c2-cdb2-4917-8ddb-d45adde6343f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("35f650bf-9893-4c81-ad8a-9e052454b088"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("498a5a7a-fb50-45f3-a2e8-63731023b22f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("51388c76-2630-4719-99a1-51827e15af2f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("51689987-3a7c-4d11-9c11-0be6c2cd8eb7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("57942e0d-5cf4-49da-9e33-e4b4622bf8f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5dabcee2-a833-4537-b155-0c156ec1a78b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("86b808fa-338e-44ee-bb88-5ef931f03af3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("87d0e47d-3e24-42d6-a861-5e2f94eb6398"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bcb3e73-a7a2-4998-ae77-c8cece37bc09"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f61d732-dc29-41e2-84ea-0712dbfd4495"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("94c6bbbc-0dd6-456a-9b12-a86b51d3fe2e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0b7d14f-81a3-446f-b82c-c98123a1450a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("afda54f6-bfef-4d5e-a045-82973a28c6ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3ce76c5-d66d-4ccc-a265-93f430ea388f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cb3b24d9-34b0-4082-a391-8478c0792ca8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d3eab625-c11c-41d0-a945-0bb31556c1fb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb9994d2-8bc4-476e-b996-f632ff89aee7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f8095775-cf5b-462b-90b5-67a19b40fa87"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faee886d-f648-413f-96d0-6e7b7e307ebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"));

            migrationBuilder.RenameTable(
                name: "UserSkill",
                newName: "UserSkills");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkill_SkillId",
                table: "UserSkills",
                newName: "IX_UserSkills_SkillId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills",
                columns: new[] { "UserId", "SkillId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "uk" },
                    { new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"), "pl" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("2dacb2b5-3f59-40f5-998f-779d49b6d401"), "medicine" },
                    { new Guid("649d816a-9e39-472a-b0fd-2fc8c3b0c6de"), "cook" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("0002442a-4113-4062-8a95-ed330c7fd247"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "vi" },
                    { new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "chk" },
                    { new Guid("194f9426-c406-492b-807f-b2928b499694"), new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"), "lub" },
                    { new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "zhy" },
                    { new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "my" },
                    { new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "khar" },
                    { new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "ky" },
                    { new Guid("637f6066-eb41-40c7-b939-8be595174659"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "lv" },
                    { new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "zp" },
                    { new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "pol" },
                    { new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "chv" },
                    { new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "ri" },
                    { new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "if" },
                    { new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "khm" },
                    { new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "od" },
                    { new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "kr" },
                    { new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "chh" },
                    { new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"), new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"), "var" },
                    { new Guid("cc471323-518d-4b46-9767-d237c58a4507"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "dn" },
                    { new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "ter" },
                    { new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "kher" },
                    { new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "su" },
                    { new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "lut" },
                    { new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "uzh" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("129487bd-1eb6-41e9-87db-b3f1aaf7abed"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "uk", "Україна" },
                    { new Guid("4871d8ea-b585-423d-b21f-6f627a23d214"), new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"), "uk", "Польша" },
                    { new Guid("53add06f-3ab3-47be-84c2-7f685f2115db"), new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"), "en", "Ukraine" },
                    { new Guid("552cbb91-5146-4d7d-838a-98a3859100d0"), new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"), "en", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("007c3aa3-2c13-4151-96d5-e3b334531548"), new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"), "uk", "Ужгород" },
                    { new Guid("129d7ec6-ee8b-44f7-839f-aa60766c5ba9"), new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"), "uk", "Харків" },
                    { new Guid("14d14efc-48b2-4973-8fe7-17566de70d5b"), new Guid("194f9426-c406-492b-807f-b2928b499694"), "en", "Lublin" },
                    { new Guid("1566132b-4e74-40de-87ce-7c5fba526a2a"), new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"), "en", "Ternopil" },
                    { new Guid("1887fb0a-653f-45ed-a1eb-e8337b899b41"), new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"), "uk", "Київ" },
                    { new Guid("1c5212e9-b96d-4ac1-b737-547ad6fcc2e9"), new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"), "en", "Chernivtsi" },
                    { new Guid("1f58e495-5209-42d1-a279-a5015cf9948a"), new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"), "en", "Lutsk" },
                    { new Guid("2714a416-b397-453c-8c82-185409c0fb0a"), new Guid("cc471323-518d-4b46-9767-d237c58a4507"), "uk", "Дніпро" },
                    { new Guid("2a4d77da-724c-4c6c-bbda-bfb8f5d53851"), new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"), "uk", "Рівне" },
                    { new Guid("3284f575-8f2c-4dbb-8660-b84caa0f4b7e"), new Guid("0002442a-4113-4062-8a95-ed330c7fd247"), "en", "Vinnytsia" },
                    { new Guid("4c0a07a1-e63f-41f3-b3ab-bce2d14cdcbc"), new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"), "uk", "Івано-Франківськ" },
                    { new Guid("58008907-15c9-4717-b526-9c8aac74633f"), new Guid("0002442a-4113-4062-8a95-ed330c7fd247"), "uk", "Вінниця" },
                    { new Guid("5ea502ee-8853-4a20-890d-ff56972cc022"), new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"), "en", "Cherkasy" },
                    { new Guid("60ce010a-971c-4913-aeb5-5568ad5adf12"), new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"), "en", "Chernihiv" },
                    { new Guid("644721fc-2a04-48eb-9958-564eb9c2b571"), new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"), "uk", "Миколаїв" },
                    { new Guid("65a35577-f637-4581-8c7d-54d6673fd104"), new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"), "uk", "Полтава" },
                    { new Guid("65ba5c73-3128-407d-8e49-79562fea3589"), new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"), "en", "Varshava" },
                    { new Guid("664b0aae-3156-4103-95ec-19638d281438"), new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"), "uk", "Хмельницький" },
                    { new Guid("6a38dc1b-1cdf-460f-8b7a-d68a5950866a"), new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"), "en", "Mykolaiv" },
                    { new Guid("6d110397-513b-4fae-bd23-73539566e218"), new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"), "uk", "Житомир" },
                    { new Guid("6fecd8bc-ac43-4820-a8bc-c315eba8c0b2"), new Guid("cc471323-518d-4b46-9767-d237c58a4507"), "en", "Dnipro" },
                    { new Guid("7a500f11-2010-47de-bc5b-d10c9118bc53"), new Guid("194f9426-c406-492b-807f-b2928b499694"), "uk", "Люблін" },
                    { new Guid("80219b32-eaa3-4558-8b20-4d23b84844f7"), new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"), "en", "Rivne" },
                    { new Guid("82f4f3b7-ec95-4e2b-aa4e-14db1b37bd46"), new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"), "en", "Kyiv" },
                    { new Guid("89bd8659-a5d1-4ecc-bc8b-8849e2e565d5"), new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"), "uk", "Суми" },
                    { new Guid("8ccc2226-a942-444f-a316-5eda5ff84013"), new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"), "uk", "Луцьк" },
                    { new Guid("8e346fdf-0cd1-4a60-9f37-1cc5513fe841"), new Guid("637f6066-eb41-40c7-b939-8be595174659"), "uk", "Львів" },
                    { new Guid("91d7b4c7-f445-456f-8ca2-af471bc4fda2"), new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"), "en", "Uzhhorod" },
                    { new Guid("936758bb-974d-462d-adaf-6c23317c3454"), new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"), "uk", "Кропивницький" },
                    { new Guid("93d6b0eb-b6d7-4119-831c-8c3e87d83c8d"), new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"), "uk", "Одеса" },
                    { new Guid("99fef125-a4e7-4fc1-a0a0-8aeb68c781cf"), new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"), "en", "Sumy" },
                    { new Guid("9cc55bea-04b1-4e18-839e-8bd883f974d1"), new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"), "uk", "Чернігів" },
                    { new Guid("9f62263d-ff82-4dc6-a6f1-57af2229811d"), new Guid("637f6066-eb41-40c7-b939-8be595174659"), "en", "Lviv" },
                    { new Guid("a067bd97-fcb2-4bdc-a72f-f00e5547c5d6"), new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"), "en", "Kharkiv" },
                    { new Guid("a4719972-547d-4c55-9c48-b9444543c710"), new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"), "uk", "Херсон" },
                    { new Guid("aa3631a9-de42-469a-87cf-3c349034b606"), new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"), "en", "Kropyvnytskyi" },
                    { new Guid("ac433634-0423-4e8e-88e6-9c717366c31f"), new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"), "uk", "Тернопіль" },
                    { new Guid("b4056414-e4b6-41f7-98b3-089aa56ec194"), new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"), "en", "Kherson" },
                    { new Guid("ba5c6d04-06e9-48a4-a8d4-b04a02f370b5"), new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"), "en", "Zhytomyr" },
                    { new Guid("bbaaa29a-c852-429b-9b3b-21105b0ff400"), new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"), "uk", "Варшава" },
                    { new Guid("bc4991b6-1b54-41ef-9250-22486e9e9b39"), new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"), "en", "Zaporizhzhia" },
                    { new Guid("c42f0ff1-6b71-4172-98d5-02718b0616c2"), new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"), "en", "Poltava" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d92e19e9-1560-4937-bf2f-6e7338bbf4d3"), new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"), "uk", "Запоріжжя" },
                    { new Guid("e011ecaa-20ca-4b64-a207-5a2f70fba828"), new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"), "en", "Ivano-Frankivsk" },
                    { new Guid("e5f52f0e-457a-4ae4-b6c4-15db13583300"), new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"), "en", "Odesa" },
                    { new Guid("ee05b82d-a9e0-4c79-af66-1ca5b716dd83"), new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"), "uk", "Черкаси" },
                    { new Guid("f1f4b5e1-4618-4367-bae8-3ff447182525"), new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"), "en", "Khmelnytskyi" },
                    { new Guid("fb114c1f-5ceb-4491-aed9-898369ee8e11"), new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"), "uk", "Чернівці" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("788eb2be-ec08-4eff-a132-a3c1cddbb959"), new Guid("0002442a-4113-4062-8a95-ed330c7fd247"), new DateTime(2023, 3, 2, 21, 43, 49, 988, DateTimeKind.Local).AddTicks(1973), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Users_UserId",
                table: "UserSkills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Users_UserId",
                table: "UserSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills");

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("007c3aa3-2c13-4151-96d5-e3b334531548"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("129d7ec6-ee8b-44f7-839f-aa60766c5ba9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("14d14efc-48b2-4973-8fe7-17566de70d5b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1566132b-4e74-40de-87ce-7c5fba526a2a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1887fb0a-653f-45ed-a1eb-e8337b899b41"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1c5212e9-b96d-4ac1-b737-547ad6fcc2e9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1f58e495-5209-42d1-a279-a5015cf9948a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2714a416-b397-453c-8c82-185409c0fb0a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2a4d77da-724c-4c6c-bbda-bfb8f5d53851"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3284f575-8f2c-4dbb-8660-b84caa0f4b7e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4c0a07a1-e63f-41f3-b3ab-bce2d14cdcbc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("58008907-15c9-4717-b526-9c8aac74633f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5ea502ee-8853-4a20-890d-ff56972cc022"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("60ce010a-971c-4913-aeb5-5568ad5adf12"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("644721fc-2a04-48eb-9958-564eb9c2b571"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("65a35577-f637-4581-8c7d-54d6673fd104"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("65ba5c73-3128-407d-8e49-79562fea3589"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("664b0aae-3156-4103-95ec-19638d281438"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6a38dc1b-1cdf-460f-8b7a-d68a5950866a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6d110397-513b-4fae-bd23-73539566e218"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6fecd8bc-ac43-4820-a8bc-c315eba8c0b2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7a500f11-2010-47de-bc5b-d10c9118bc53"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("80219b32-eaa3-4558-8b20-4d23b84844f7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("82f4f3b7-ec95-4e2b-aa4e-14db1b37bd46"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("89bd8659-a5d1-4ecc-bc8b-8849e2e565d5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8ccc2226-a942-444f-a316-5eda5ff84013"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8e346fdf-0cd1-4a60-9f37-1cc5513fe841"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("91d7b4c7-f445-456f-8ca2-af471bc4fda2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("936758bb-974d-462d-adaf-6c23317c3454"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("93d6b0eb-b6d7-4119-831c-8c3e87d83c8d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("99fef125-a4e7-4fc1-a0a0-8aeb68c781cf"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9cc55bea-04b1-4e18-839e-8bd883f974d1"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9f62263d-ff82-4dc6-a6f1-57af2229811d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a067bd97-fcb2-4bdc-a72f-f00e5547c5d6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a4719972-547d-4c55-9c48-b9444543c710"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("aa3631a9-de42-469a-87cf-3c349034b606"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ac433634-0423-4e8e-88e6-9c717366c31f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b4056414-e4b6-41f7-98b3-089aa56ec194"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ba5c6d04-06e9-48a4-a8d4-b04a02f370b5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bbaaa29a-c852-429b-9b3b-21105b0ff400"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bc4991b6-1b54-41ef-9250-22486e9e9b39"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c42f0ff1-6b71-4172-98d5-02718b0616c2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d92e19e9-1560-4937-bf2f-6e7338bbf4d3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e011ecaa-20ca-4b64-a207-5a2f70fba828"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e5f52f0e-457a-4ae4-b6c4-15db13583300"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ee05b82d-a9e0-4c79-af66-1ca5b716dd83"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f1f4b5e1-4618-4367-bae8-3ff447182525"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fb114c1f-5ceb-4491-aed9-898369ee8e11"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("129487bd-1eb6-41e9-87db-b3f1aaf7abed"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4871d8ea-b585-423d-b21f-6f627a23d214"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("53add06f-3ab3-47be-84c2-7f685f2115db"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("552cbb91-5146-4d7d-838a-98a3859100d0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2dacb2b5-3f59-40f5-998f-779d49b6d401"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("649d816a-9e39-472a-b0fd-2fc8c3b0c6de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("788eb2be-ec08-4eff-a132-a3c1cddbb959"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0002442a-4113-4062-8a95-ed330c7fd247"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("194f9426-c406-492b-807f-b2928b499694"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("637f6066-eb41-40c7-b939-8be595174659"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cc471323-518d-4b46-9767-d237c58a4507"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserSkills");

            migrationBuilder.RenameTable(
                name: "UserSkills",
                newName: "UserSkill");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkill",
                newName: "IX_UserSkill_SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill",
                columns: new[] { "UserId", "SkillId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"), "pl" },
                    { new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("83b648e6-86fb-4aec-ab72-df2d87f47b4f"), "cook" },
                    { new Guid("e1fd7138-bf1a-41bd-9961-27439c4ade44"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("012b8f73-37db-4bbd-9dff-301a14cd9784"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "my" },
                    { new Guid("01525635-6fbb-4635-a0a1-0bfa0562f01e"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "zhy" },
                    { new Guid("04de4d25-9326-4bf2-a193-75d4670198c8"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "dn" },
                    { new Guid("0fada013-f8ac-42bc-b88f-e34338f2fd6d"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "khm" },
                    { new Guid("2ff7f6c2-cdb2-4917-8ddb-d45adde6343f"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "kr" },
                    { new Guid("35f650bf-9893-4c81-ad8a-9e052454b088"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "kher" },
                    { new Guid("498a5a7a-fb50-45f3-a2e8-63731023b22f"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "chv" },
                    { new Guid("51388c76-2630-4719-99a1-51827e15af2f"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "pol" },
                    { new Guid("51689987-3a7c-4d11-9c11-0be6c2cd8eb7"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "od" },
                    { new Guid("57942e0d-5cf4-49da-9e33-e4b4622bf8f8"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "chh" },
                    { new Guid("5dabcee2-a833-4537-b155-0c156ec1a78b"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "lut" },
                    { new Guid("86b808fa-338e-44ee-bb88-5ef931f03af3"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "ter" },
                    { new Guid("87d0e47d-3e24-42d6-a861-5e2f94eb6398"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "khar" },
                    { new Guid("8bcb3e73-a7a2-4998-ae77-c8cece37bc09"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "vi" },
                    { new Guid("8f61d732-dc29-41e2-84ea-0712dbfd4495"), new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"), "var" },
                    { new Guid("94c6bbbc-0dd6-456a-9b12-a86b51d3fe2e"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "chk" },
                    { new Guid("a0b7d14f-81a3-446f-b82c-c98123a1450a"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "su" },
                    { new Guid("afda54f6-bfef-4d5e-a045-82973a28c6ad"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "ri" },
                    { new Guid("b3ce76c5-d66d-4ccc-a265-93f430ea388f"), new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"), "lub" },
                    { new Guid("cb3b24d9-34b0-4082-a391-8478c0792ca8"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "zp" },
                    { new Guid("d3eab625-c11c-41d0-a945-0bb31556c1fb"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "ky" },
                    { new Guid("eb9994d2-8bc4-476e-b996-f632ff89aee7"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "lv" },
                    { new Guid("f8095775-cf5b-462b-90b5-67a19b40fa87"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "uzh" },
                    { new Guid("faee886d-f648-413f-96d0-6e7b7e307ebd"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "if" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("464be5bc-5e2f-4470-a41d-e7e462c5645d"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "en", "Ukraine" },
                    { new Guid("535bc928-2bfe-4c2f-bcb2-c3080f2d6395"), new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"), "en", "Poland" },
                    { new Guid("6ec95273-8479-4ebe-aa2b-6986c98dc89e"), new Guid("59e8a4d4-f8ed-4b3f-bacf-a02b1f6d6af7"), "uk", "Україна" },
                    { new Guid("e72569c6-bc9b-4f27-9180-86ab0c4d09d1"), new Guid("40901e60-b59d-4187-adb5-d04b95cc2f00"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0da1d5bb-6d9c-4127-84d0-fe23aa55d414"), new Guid("51388c76-2630-4719-99a1-51827e15af2f"), "uk", "Полтава" },
                    { new Guid("1fcfee7c-522c-486c-a6d6-8211df6aa9a1"), new Guid("d3eab625-c11c-41d0-a945-0bb31556c1fb"), "uk", "Київ" },
                    { new Guid("201eebdc-2c7c-4b3c-9b9e-06f1fb8d8984"), new Guid("8f61d732-dc29-41e2-84ea-0712dbfd4495"), "en", "Varshava" },
                    { new Guid("2ac8cc26-0439-40c1-a327-74466dbb378c"), new Guid("86b808fa-338e-44ee-bb88-5ef931f03af3"), "en", "Ternopil" },
                    { new Guid("2df58756-4435-446b-86fb-c0aa79eac53e"), new Guid("94c6bbbc-0dd6-456a-9b12-a86b51d3fe2e"), "uk", "Черкаси" },
                    { new Guid("34494f1c-b65c-42f1-84f8-358057fa0abc"), new Guid("51689987-3a7c-4d11-9c11-0be6c2cd8eb7"), "uk", "Одеса" },
                    { new Guid("357d3bc8-1f9c-4062-b685-ab0bcd9aed78"), new Guid("012b8f73-37db-4bbd-9dff-301a14cd9784"), "uk", "Миколаїв" },
                    { new Guid("36fb0298-89fb-442e-a5d2-06b037d357a3"), new Guid("86b808fa-338e-44ee-bb88-5ef931f03af3"), "uk", "Тернопіль" },
                    { new Guid("3f0eaac8-c4b7-46d7-a2e1-3b3f9ff6b941"), new Guid("57942e0d-5cf4-49da-9e33-e4b4622bf8f8"), "uk", "Чернігів" },
                    { new Guid("4031cbec-e585-489c-ae6c-fe22e2a81602"), new Guid("d3eab625-c11c-41d0-a945-0bb31556c1fb"), "en", "Kyiv" },
                    { new Guid("40d433fc-f568-4406-9c0e-3ecacc40c9e3"), new Guid("5dabcee2-a833-4537-b155-0c156ec1a78b"), "uk", "Луцьк" },
                    { new Guid("41f2dae9-302b-4ed8-b106-e80b0cb7006c"), new Guid("35f650bf-9893-4c81-ad8a-9e052454b088"), "uk", "Херсон" },
                    { new Guid("42cca5d2-5a9e-4f75-a7c4-932da19c2a00"), new Guid("0fada013-f8ac-42bc-b88f-e34338f2fd6d"), "en", "Khmelnytskyi" },
                    { new Guid("47fb25ec-1cb8-4257-b19e-4ea6a5e410a6"), new Guid("51388c76-2630-4719-99a1-51827e15af2f"), "en", "Poltava" },
                    { new Guid("5a0cdbbb-f5a3-4e0f-96e0-71748b6b138e"), new Guid("8bcb3e73-a7a2-4998-ae77-c8cece37bc09"), "en", "Vinnytsia" },
                    { new Guid("5aa122a2-329b-49ce-bfd9-04f1286f5a35"), new Guid("57942e0d-5cf4-49da-9e33-e4b4622bf8f8"), "en", "Chernihiv" },
                    { new Guid("5d5da4b6-b341-4e1a-8974-7041b4b83a20"), new Guid("a0b7d14f-81a3-446f-b82c-c98123a1450a"), "en", "Sumy" },
                    { new Guid("64baff49-073b-4cb1-acca-3f747d7cf198"), new Guid("87d0e47d-3e24-42d6-a861-5e2f94eb6398"), "en", "Kharkiv" },
                    { new Guid("68a572be-fea9-4c27-86c7-749c4afd694d"), new Guid("eb9994d2-8bc4-476e-b996-f632ff89aee7"), "uk", "Львів" },
                    { new Guid("69dac06e-fa38-4ec3-b5aa-3b501b552ed3"), new Guid("8f61d732-dc29-41e2-84ea-0712dbfd4495"), "uk", "Варшава" },
                    { new Guid("6e54d645-38fb-4eb9-a58c-d9029aa47702"), new Guid("0fada013-f8ac-42bc-b88f-e34338f2fd6d"), "uk", "Хмельницький" },
                    { new Guid("6fdcdcbe-24a4-4795-b538-7baa3159abb8"), new Guid("8bcb3e73-a7a2-4998-ae77-c8cece37bc09"), "uk", "Вінниця" },
                    { new Guid("76d31c2e-5688-4751-b012-7ba3e37fd32c"), new Guid("35f650bf-9893-4c81-ad8a-9e052454b088"), "en", "Kherson" },
                    { new Guid("7736a5be-0c00-4889-8b08-0dcf3dde3dce"), new Guid("b3ce76c5-d66d-4ccc-a265-93f430ea388f"), "uk", "Люблін" },
                    { new Guid("78644915-50e7-4bd7-b48a-f92944d1d22e"), new Guid("498a5a7a-fb50-45f3-a2e8-63731023b22f"), "uk", "Чернівці" },
                    { new Guid("7c60fc11-39b9-47f8-aa54-fd037fb0db89"), new Guid("f8095775-cf5b-462b-90b5-67a19b40fa87"), "en", "Uzhhorod" },
                    { new Guid("88bfdea0-2239-45e6-b4d1-be2e55f2f4ff"), new Guid("eb9994d2-8bc4-476e-b996-f632ff89aee7"), "en", "Lviv" },
                    { new Guid("93737d70-b818-4eea-9b12-b0317e68f3ae"), new Guid("04de4d25-9326-4bf2-a193-75d4670198c8"), "uk", "Дніпро" },
                    { new Guid("96d2ec16-795b-443e-bc65-6366d51bea96"), new Guid("cb3b24d9-34b0-4082-a391-8478c0792ca8"), "uk", "Запоріжжя" },
                    { new Guid("97e46c75-1867-4772-b344-18a5cb65d002"), new Guid("cb3b24d9-34b0-4082-a391-8478c0792ca8"), "en", "Zaporizhzhia" },
                    { new Guid("9d27be89-1964-446c-8cc6-2e1013a48d7c"), new Guid("01525635-6fbb-4635-a0a1-0bfa0562f01e"), "uk", "Житомир" },
                    { new Guid("9e92e71b-4dae-4361-9aca-5cac0f5bf48f"), new Guid("04de4d25-9326-4bf2-a193-75d4670198c8"), "en", "Dnipro" },
                    { new Guid("a765ff8f-f643-40b0-ab0e-223345a91206"), new Guid("012b8f73-37db-4bbd-9dff-301a14cd9784"), "en", "Mykolaiv" },
                    { new Guid("acf0b1e9-5535-446e-8f99-651990c207c0"), new Guid("2ff7f6c2-cdb2-4917-8ddb-d45adde6343f"), "en", "Kropyvnytskyi" },
                    { new Guid("c2f3cb62-a285-45cd-bcf0-49410168fa25"), new Guid("94c6bbbc-0dd6-456a-9b12-a86b51d3fe2e"), "en", "Cherkasy" },
                    { new Guid("c4e9906e-7de4-4b28-85d8-66179abda67e"), new Guid("f8095775-cf5b-462b-90b5-67a19b40fa87"), "uk", "Ужгород" },
                    { new Guid("c73167ad-6539-4a71-95e0-a55164377c32"), new Guid("51689987-3a7c-4d11-9c11-0be6c2cd8eb7"), "en", "Odesa" },
                    { new Guid("c813c9d6-f2b1-4f2a-aed1-d6b74641a666"), new Guid("b3ce76c5-d66d-4ccc-a265-93f430ea388f"), "en", "Lublin" },
                    { new Guid("d9238879-7cee-4f44-b30d-bb2e1f178e04"), new Guid("01525635-6fbb-4635-a0a1-0bfa0562f01e"), "en", "Zhytomyr" },
                    { new Guid("f24fe0a0-7f2a-4188-8aae-3a8624d25afd"), new Guid("2ff7f6c2-cdb2-4917-8ddb-d45adde6343f"), "uk", "Кропивницький" },
                    { new Guid("f2bcec47-f729-4565-822b-e617aef3b44a"), new Guid("a0b7d14f-81a3-446f-b82c-c98123a1450a"), "uk", "Суми" },
                    { new Guid("f3f52cc4-d49c-4d08-bc1e-242352343683"), new Guid("afda54f6-bfef-4d5e-a045-82973a28c6ad"), "en", "Rivne" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("f7e8c205-093f-405f-9c02-8b91c81f8e93"), new Guid("498a5a7a-fb50-45f3-a2e8-63731023b22f"), "en", "Chernivtsi" },
                    { new Guid("f919ce55-ac08-4a3b-9805-0c8341e1be7a"), new Guid("faee886d-f648-413f-96d0-6e7b7e307ebd"), "en", "Ivano-Frankivsk" },
                    { new Guid("fb024c72-95ea-4862-adc3-9a0e91891bd8"), new Guid("87d0e47d-3e24-42d6-a861-5e2f94eb6398"), "uk", "Харків" },
                    { new Guid("fbbc585a-c8d3-41e8-af04-8597d96a73dd"), new Guid("faee886d-f648-413f-96d0-6e7b7e307ebd"), "uk", "Івано-Франківськ" },
                    { new Guid("fe4b045c-5d5e-426c-a464-39b7f3f1729a"), new Guid("5dabcee2-a833-4537-b155-0c156ec1a78b"), "en", "Lutsk" },
                    { new Guid("ff2e1834-5e30-44bb-938f-a9e0049c738c"), new Guid("afda54f6-bfef-4d5e-a045-82973a28c6ad"), "uk", "Рівне" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("94fd4913-c866-42d2-83aa-053e99946b25"), new Guid("8bcb3e73-a7a2-4998-ae77-c8cece37bc09"), new DateTime(2023, 2, 22, 22, 45, 32, 361, DateTimeKind.Local).AddTicks(7930), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_Skills_SkillId",
                table: "UserSkill",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_Users_UserId",
                table: "UserSkill",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

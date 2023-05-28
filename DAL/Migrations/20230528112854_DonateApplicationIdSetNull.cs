using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DonateApplicationIdSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donates_Applications_ApplicationId",
                table: "Donates");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("012951da-a01f-428a-95de-982c91f292a5"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("181c9ab8-29be-45ef-9844-f8967c62895b"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("23e967a2-ea88-4c5d-acd8-03583beb3d8a"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("25785996-28d3-4d03-972e-8861d81e949b"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("340a9e95-f02e-49bc-bc23-de17c4c60b40"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("66004077-e002-4605-9c5a-3616a6b8a21c"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("69acc5f5-b7a5-4cb9-8d96-8d4c6a7e34e5"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("94c1c6e0-e960-4956-a65f-13b9eb30082c"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("94ef0a2e-4835-42a2-8c58-5f435def10bc"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e5702365-fd30-494c-922b-107c3434a3fa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0533e4eb-7f9e-42d5-bf85-1b81b19fc302"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("07f30d7f-ef06-4364-91c1-0af1d0a1f474"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("09d30c5b-d6eb-43ac-a5bf-8fcd97ebbfcc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("10eca06f-28b7-4a24-9d84-5540e41a8867"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("180b7857-0152-4588-9dda-1ba25540ebfa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("1e0a64e7-6fbc-4285-8354-4e815384d0e6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("246501c4-5693-49cc-930c-e65bba713377"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2ccf8f17-ff31-4072-80fc-5bf66cc20c8e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2fec43be-ea65-4a24-b1dc-4d8edfeab3d5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("358ea2d7-c256-416f-813c-6a8fdd5056b5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("36d36660-91e6-4151-bd05-2a09e7f9a0e9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3a84a5ae-9952-496d-ba19-532df3927dc2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("47eecf6c-4840-4bbb-9043-9bcbb81a3838"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4a20c207-07b8-4320-bfa6-8622d55de0a2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4e7b4fa5-53f8-4be0-8d76-9cca89131d6e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("4ec68777-8a20-47a6-b979-2fd2d2288979"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("561461bd-016b-46c0-825e-149a80d7226b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("58d03d28-7bca-4ed0-857d-e73db05cb021"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5e074313-d3c2-48cd-bee5-68559fd72d8f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("60ea73f7-5de2-4748-9376-157ed85c9edb"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("64a68285-649d-4555-9b94-47bb2682337f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("655295a9-3617-4884-9fe7-7b6a786f2ecb"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6772ce1b-7f87-4814-b296-fe4056c66212"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("67a1a5c3-e493-44f0-9fcf-96b1ff243da4"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6b8ba8fa-2c26-4463-baba-56b96d6654fa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6e715c41-8725-445a-957b-237a47cc7ccc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("80d0b99b-c5ac-4374-a86e-69af2e1c04a3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("81526597-92be-4717-9528-c88e4783c373"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("81da23bc-b504-40aa-beb1-f93cb19ec2a3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("82b412d3-e1da-4e7f-86e1-61dcb9cdb3a9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9290b6d7-3168-43bb-9b38-add1ad9352d5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("94da7a9a-27ca-4dc7-8e53-40f04402a070"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9b9cfae8-6db1-4d6d-9e7d-070a6fb9ac7a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9ee961e3-51fb-4884-b5f3-ddc11f9a01fe"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a38aecd0-2d3a-4d61-9a9c-2c973522f77d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a442a2da-eda8-41e0-b271-f97d1952bb4f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a9f8aeeb-08db-47b4-ba07-331700b1dfe4"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("aaf920d1-297d-42de-837b-d2e6d2417d10"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c275a99d-8c37-4ffa-85dc-be0967eb150b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c63d2d44-dc99-4408-8308-297bd09cc46c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cbcaaf69-bd2c-416c-8919-0ac96b20c484"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d24212a7-aa33-4005-a1a8-005d7ed0956a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d9b4ef54-8361-472d-b731-15e5e8abb506"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e344eb3a-d234-4e99-9b0f-880aac8ef2a6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ed6207eb-530e-4cfa-8a3a-32d9e4202285"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f2e91a2d-7c20-4d68-a9e5-2de15b657bfd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f4b247d5-875f-4ead-8b62-db3b48786acc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f9c5c484-76bc-4de6-bb3d-962b0b03f498"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0540d890-7e59-4544-9f3f-82d4d5ae560f"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("06f4c740-2f50-4922-bcc6-2808e919be1b"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("71ebcb95-a103-48d3-84d1-52ec8eb88d69"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("80218614-9035-4251-b1a7-15447cb1e3cb"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("17479483-8c69-4899-a6c7-796866c4a9c8"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("237e5dbc-f065-4e87-a92e-f6c01488b2ce"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("46a70530-bbb3-4cb8-8aaf-8902b151f3a3"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("56df03fc-2b61-4b3b-9f8a-014eea6e5692"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7d4a1ff5-f46a-425f-b4d7-de6e1ed8fdf1"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a4954a9e-d86a-4292-a9b0-7645345f3d7a"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("aec25848-a151-4761-9757-ab7ee24c8fb6"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c8e98ce4-cf7a-4c31-9a69-9cd7b5f10cce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2516916c-614b-493a-a819-a0f58527a71b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ba5d2c2-2fb6-4ef4-bda6-94df28f03169"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73405840-06c7-4169-ad1c-a7e68c67f1dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7486617d-4d74-4187-b567-dfa86159ebe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1eb1bf2-06d0-4aa7-9599-6c7861d49bcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e279e8e5-93c1-4cd8-86ca-28e79b0830b1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("249367a5-add6-4f1c-a803-d55e45e8d4a6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("35e4c480-9cf5-4ec7-bff8-fb8d870203ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36b5f355-fc4f-4ea0-9fc0-d6071b4d4122"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("41a4f995-6e36-4e71-8c59-87235b379f2a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b0cbfb4-eaea-40ed-adf0-9bdb57168221"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5738bfef-0918-4cc7-b667-f07fb01773f6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5ab3e6d9-c715-4d83-a126-d31e55fc62f4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6e50a4de-65fb-4321-95d4-2f6eef3ab701"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e96c1e2-0280-4641-8e62-c93b14be6276"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8757a185-287b-4cef-b085-9a62f36f0b64"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9019b793-227e-44b9-b300-64cc14e15c26"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("932a31d2-ae38-419a-8c47-6f02f81aa14b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("97ec3f0d-f4f0-4604-b75a-3854c8a41ad9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a1c3b944-151f-4a42-877c-92b663bcb748"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a75777ab-9482-469e-8002-383671fd3365"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1ebcc5b-78ae-485c-9d1f-bba6e57aee31"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cb972141-1a48-4079-993d-bf9f3c14e01e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d1376531-b118-411e-aaa1-6bd4b20ecd9a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d52852a1-db2b-4347-bbf3-3407a589ea5f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d604c9a2-4168-467e-920a-c827919ebfc7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e064f96b-ef7f-4b5a-8cdd-c60cd020685f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e11ea064-7adb-4eed-a71d-434629a6fdd1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e76dab51-bda2-4f4c-a556-3eb6aa2b092d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e98303f4-5fe9-4047-823c-b8db96e54a40"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0a27f1ba-d94d-4e1c-ab59-99952e96764b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3d2c6f42-1943-4f69-b501-79de78afe8af"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a34e7e3a-336a-4d76-adb3-fcec13a5e1f6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a550ef1c-5eb1-4341-ba58-6cafa27c003a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationId",
                table: "Donates",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("5534bdcc-ae0b-4075-903f-504fecd26b47"), "social programs" },
                    { new Guid("6cffd041-3f98-4cf9-a151-baa930b7b63c"), "health care" },
                    { new Guid("9cd4aa92-7723-460a-81d4-62a39469187a"), "culture and art" },
                    { new Guid("a3c27e53-7a00-478d-b9d6-cb5d60d03062"), "education" },
                    { new Guid("fabf934e-80e8-42d5-b878-98ec1dfe2ec9"), "sports and physical culture" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "uk" },
                    { new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"), "pl" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0d280e1f-998f-49a7-9b4c-48cb1bbf5274"), "psychology" },
                    { new Guid("137647b7-f42a-46a0-984b-9cfd457e1aba"), "cooking" },
                    { new Guid("83f1af7b-d18e-42d6-b15c-e2c929fb596c"), "medicine" },
                    { new Guid("bf83c741-70e5-4ddf-b597-2e4cd077c914"), "building" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "DescriptionCategory", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("07363ecb-71f3-4184-a711-cd473c3af550"), new Guid("fabf934e-80e8-42d5-b878-98ec1dfe2ec9"), " ", "en", "sport and physical culture" },
                    { new Guid("34e8e3b4-3602-463c-ac0c-7267e37f6394"), new Guid("5534bdcc-ae0b-4075-903f-504fecd26b47"), " ", "uk", "соціальні програми" },
                    { new Guid("85453b53-0cd6-4fbe-8c17-187aa0ae21ba"), new Guid("fabf934e-80e8-42d5-b878-98ec1dfe2ec9"), " ", "uk", "спорт та фізична культура" },
                    { new Guid("acdcb2b2-02fb-4030-aacf-b9d3a86f93ee"), new Guid("6cffd041-3f98-4cf9-a151-baa930b7b63c"), " ", "en", "health care" },
                    { new Guid("b3a88d68-09e6-4a16-9a2b-946caef064a0"), new Guid("a3c27e53-7a00-478d-b9d6-cb5d60d03062"), " ", "en", "education" },
                    { new Guid("be522fd5-cc6a-4165-b08d-d77fafb3f787"), new Guid("6cffd041-3f98-4cf9-a151-baa930b7b63c"), " ", "uk", "охорона здоров'я" },
                    { new Guid("cceb19d8-f1ef-4c4c-b4bd-26c5d0f155ee"), new Guid("5534bdcc-ae0b-4075-903f-504fecd26b47"), " ", "en", "social programs" },
                    { new Guid("cf155cee-051e-4904-8553-e5f802d3c032"), new Guid("9cd4aa92-7723-460a-81d4-62a39469187a"), " ", "en", "culture and art" },
                    { new Guid("d58a7c01-e891-46db-9eff-8fffb40e2b90"), new Guid("9cd4aa92-7723-460a-81d4-62a39469187a"), " ", "uk", "культура та мистецтво" },
                    { new Guid("e74af47d-3e3c-4629-bfc2-7204596c1d8c"), new Guid("a3c27e53-7a00-478d-b9d6-cb5d60d03062"), " ", "uk", "освіта" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("157d6706-3c85-45e3-bb46-bdf2d44d0fb8"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "lut" },
                    { new Guid("1c84b100-3762-46f3-957d-5aee7ef72372"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "ter" },
                    { new Guid("293653a4-1773-4d54-9ffc-b8498df8d3f0"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "ky" },
                    { new Guid("2fbf8f05-d281-4dbc-852c-956dfaa66b61"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "ri" },
                    { new Guid("3583680e-2f34-4347-8d09-c362ee0e1bb2"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "od" },
                    { new Guid("46177a57-7f0b-41e2-a08d-7bb64100968c"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "chh" },
                    { new Guid("5a584759-29dc-48bd-91f4-7a7a1124f5b6"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "if" },
                    { new Guid("68f4a226-5e24-446a-a9fb-a8a86d7f939f"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "zhy" },
                    { new Guid("7b18ce0f-fadb-43c6-b09d-24122562c055"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "su" },
                    { new Guid("827787c2-5977-4b65-87e6-736a252dc443"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "chv" },
                    { new Guid("86493d1d-f4b7-43b3-984b-3c2228ece112"), new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"), "var" },
                    { new Guid("8b50725c-c16e-4f35-a136-047e9ec018f7"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "vi" },
                    { new Guid("8db1b9a2-3e26-44b0-8a72-b8225190e8b3"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "kr" },
                    { new Guid("a1a22884-d29a-4fbe-9e4f-0647535266e2"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "uzh" },
                    { new Guid("a6d477eb-a32f-4cdd-87a4-a850d4f92c79"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "lv" },
                    { new Guid("a903e98b-d863-4595-a405-b4f263d1cdc4"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "khar" },
                    { new Guid("b683b76f-a05c-467c-98d6-f9b25bf46a97"), new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"), "lub" },
                    { new Guid("c25f3c4a-2e13-4844-beb1-3b2a3b46c0a4"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "khm" },
                    { new Guid("c4940670-f991-4968-985c-c3d517dcd114"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "pol" },
                    { new Guid("c9237575-d028-406e-a7c7-9c5f5e53e87b"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "zp" },
                    { new Guid("f36abbad-e3e9-4e44-8287-9607f7bc13ce"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "kher" },
                    { new Guid("f561b6c5-de41-46b1-951c-5f87f3316b37"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "dn" },
                    { new Guid("f6766f2b-0fc2-466b-b91f-9732af19dd97"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "chk" },
                    { new Guid("fb2d6b2a-aa74-4332-8382-2c1814b799ee"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "my" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("18b07008-ee87-42c1-8f45-6dd2be3e0824"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "en", "Ukraine" },
                    { new Guid("3743aad5-fc25-4dba-95fd-f2dfa1c021ed"), new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"), "uk", "Польша" },
                    { new Guid("88d6e487-f78c-46fb-a084-9678cb8efee5"), new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"), "uk", "Україна" },
                    { new Guid("e099b482-2aef-4f25-8f3f-6ef023f67dc7"), new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"), "en", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("2276803c-4b1d-4a28-84c8-346d5365df66"), "en", "medicine", new Guid("83f1af7b-d18e-42d6-b15c-e2c929fb596c") },
                    { new Guid("59dd2315-d166-457c-8cd3-4fd972012a88"), "en", "psychology", new Guid("0d280e1f-998f-49a7-9b4c-48cb1bbf5274") },
                    { new Guid("6f5cc9b9-2123-4d01-8b89-98765e3f51d0"), "uk", "кулінарія", new Guid("137647b7-f42a-46a0-984b-9cfd457e1aba") },
                    { new Guid("795d45a6-fe94-4681-bed9-51afd3e2c83d"), "uk", "медицина", new Guid("83f1af7b-d18e-42d6-b15c-e2c929fb596c") }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("9e5ee1b5-04d7-4e28-a122-36ce89f023fb"), "en", "building", new Guid("bf83c741-70e5-4ddf-b597-2e4cd077c914") },
                    { new Guid("a6a15903-80cc-4bf6-89a9-b8b1bde22ca4"), "uk", "будівництво", new Guid("bf83c741-70e5-4ddf-b597-2e4cd077c914") },
                    { new Guid("ba131086-3287-4973-beb3-8a22606728cc"), "uk", "психологія", new Guid("0d280e1f-998f-49a7-9b4c-48cb1bbf5274") },
                    { new Guid("c6d8e900-706f-4e91-9d7b-9cc812dadcea"), "en", "cooking", new Guid("137647b7-f42a-46a0-984b-9cfd457e1aba") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0153a83f-ea71-42c3-b718-32e67e292145"), new Guid("293653a4-1773-4d54-9ffc-b8498df8d3f0"), "uk", "Київ" },
                    { new Guid("082df4ab-c559-4d08-8623-76538d859476"), new Guid("1c84b100-3762-46f3-957d-5aee7ef72372"), "en", "Ternopil" },
                    { new Guid("0df0a6e5-2c61-496f-abf4-941f6e9c65a0"), new Guid("86493d1d-f4b7-43b3-984b-3c2228ece112"), "uk", "Варшава" },
                    { new Guid("0f07c8a4-a5e2-4d07-aba6-e63eeca97700"), new Guid("1c84b100-3762-46f3-957d-5aee7ef72372"), "uk", "Тернопіль" },
                    { new Guid("131ecd91-8a49-4a10-b0ba-e0f16c41eae5"), new Guid("a6d477eb-a32f-4cdd-87a4-a850d4f92c79"), "en", "Lviv" },
                    { new Guid("325d2207-d396-4c1e-849a-2d21a4f51281"), new Guid("7b18ce0f-fadb-43c6-b09d-24122562c055"), "uk", "Суми" },
                    { new Guid("3eda8853-5d61-4827-abaf-db97779ca4f0"), new Guid("f6766f2b-0fc2-466b-b91f-9732af19dd97"), "en", "Cherkasy" },
                    { new Guid("52de48e9-1dc4-4e57-a94f-2e1fbb1499d9"), new Guid("fb2d6b2a-aa74-4332-8382-2c1814b799ee"), "uk", "Миколаїв" },
                    { new Guid("57ab02f0-7b54-4b81-a520-a43012a05085"), new Guid("f36abbad-e3e9-4e44-8287-9607f7bc13ce"), "en", "Kherson" },
                    { new Guid("5acb26ff-8627-4177-a509-00c88040bce0"), new Guid("f561b6c5-de41-46b1-951c-5f87f3316b37"), "en", "Dnipro" },
                    { new Guid("667b295f-cbf2-4c62-be6d-9f16441fc9e2"), new Guid("a1a22884-d29a-4fbe-9e4f-0647535266e2"), "uk", "Ужгород" },
                    { new Guid("66875fcd-8f63-4f38-bf39-1788be9cabba"), new Guid("c25f3c4a-2e13-4844-beb1-3b2a3b46c0a4"), "en", "Khmelnytskyi" },
                    { new Guid("6b021472-0cac-4c83-8105-e54d3cccd536"), new Guid("293653a4-1773-4d54-9ffc-b8498df8d3f0"), "en", "Kyiv" },
                    { new Guid("6e3e8ee1-88da-4004-b396-5f6a3a637273"), new Guid("46177a57-7f0b-41e2-a08d-7bb64100968c"), "uk", "Чернігів" },
                    { new Guid("6f8985b8-9a11-499c-b686-43c88285264a"), new Guid("c4940670-f991-4968-985c-c3d517dcd114"), "uk", "Полтава" },
                    { new Guid("744ba161-63af-4040-9baa-1eb28be34582"), new Guid("c9237575-d028-406e-a7c7-9c5f5e53e87b"), "en", "Zaporizhzhia" },
                    { new Guid("83050420-19e6-4dc6-84b4-8134ed3b8c58"), new Guid("3583680e-2f34-4347-8d09-c362ee0e1bb2"), "uk", "Одеса" },
                    { new Guid("89c84fab-7553-472b-b806-7e760a253582"), new Guid("7b18ce0f-fadb-43c6-b09d-24122562c055"), "en", "Sumy" },
                    { new Guid("8b80e892-4e3a-4821-9d8e-ee9f9cad4932"), new Guid("a6d477eb-a32f-4cdd-87a4-a850d4f92c79"), "uk", "Львів" },
                    { new Guid("9609685d-bae7-4a0e-9264-b3b2de8141bf"), new Guid("157d6706-3c85-45e3-bb46-bdf2d44d0fb8"), "en", "Lutsk" },
                    { new Guid("9756a4b8-8a8c-4dee-9f85-2490be3f92c6"), new Guid("86493d1d-f4b7-43b3-984b-3c2228ece112"), "en", "Varshava" },
                    { new Guid("993b293a-539c-4630-b032-cdef54bc6462"), new Guid("68f4a226-5e24-446a-a9fb-a8a86d7f939f"), "en", "Zhytomyr" },
                    { new Guid("9ae00b3d-5eae-4376-98e2-39f65500b2aa"), new Guid("a903e98b-d863-4595-a405-b4f263d1cdc4"), "en", "Kharkiv" },
                    { new Guid("9dac26ff-01b4-45b9-a956-31386219b412"), new Guid("f6766f2b-0fc2-466b-b91f-9732af19dd97"), "uk", "Черкаси" },
                    { new Guid("a2383d06-8504-42dd-8abb-a663a9e8dd0b"), new Guid("8db1b9a2-3e26-44b0-8a72-b8225190e8b3"), "en", "Kropyvnytskyi" },
                    { new Guid("a4595e09-cb00-44ba-9d2c-2c5b512450b3"), new Guid("5a584759-29dc-48bd-91f4-7a7a1124f5b6"), "en", "Ivano-Frankivsk" },
                    { new Guid("a4a5daae-b54a-4a49-be50-c2408dae78b3"), new Guid("68f4a226-5e24-446a-a9fb-a8a86d7f939f"), "uk", "Житомир" },
                    { new Guid("a88dbdfe-04c9-41fe-90e6-be30b6063148"), new Guid("157d6706-3c85-45e3-bb46-bdf2d44d0fb8"), "uk", "Луцьк" },
                    { new Guid("af6017f8-03f0-44a6-b2f2-57b799e7351b"), new Guid("827787c2-5977-4b65-87e6-736a252dc443"), "uk", "Чернівці" },
                    { new Guid("b06216a0-e951-4f7a-8a95-d17d80b7f171"), new Guid("c25f3c4a-2e13-4844-beb1-3b2a3b46c0a4"), "uk", "Хмельницький" },
                    { new Guid("b8e66a80-7d20-4ce5-ae96-635ecb3755de"), new Guid("a1a22884-d29a-4fbe-9e4f-0647535266e2"), "en", "Uzhhorod" },
                    { new Guid("bccbd26e-2f68-4e07-876b-9c15a05a919a"), new Guid("c4940670-f991-4968-985c-c3d517dcd114"), "en", "Poltava" },
                    { new Guid("bd7bf68b-0eef-4434-a3b4-123f113662b4"), new Guid("c9237575-d028-406e-a7c7-9c5f5e53e87b"), "uk", "Запоріжжя" },
                    { new Guid("bdd3fd58-ae1b-4f8b-9de2-d365ceb6f0a5"), new Guid("8db1b9a2-3e26-44b0-8a72-b8225190e8b3"), "uk", "Кропивницький" },
                    { new Guid("c7361daa-045e-4487-a8b0-de2c1f475b39"), new Guid("2fbf8f05-d281-4dbc-852c-956dfaa66b61"), "en", "Rivne" },
                    { new Guid("c89984f2-e162-4903-a52f-43caa5e610c9"), new Guid("fb2d6b2a-aa74-4332-8382-2c1814b799ee"), "en", "Mykolaiv" },
                    { new Guid("cc35fe52-9fe3-405d-b72b-14c1a68c0945"), new Guid("f561b6c5-de41-46b1-951c-5f87f3316b37"), "uk", "Дніпро" },
                    { new Guid("cf2d81ef-5b4e-4ea2-a693-31fd9269b0db"), new Guid("f36abbad-e3e9-4e44-8287-9607f7bc13ce"), "uk", "Херсон" },
                    { new Guid("d6016dcd-5c60-4c3e-ae28-85ae7b047a5b"), new Guid("b683b76f-a05c-467c-98d6-f9b25bf46a97"), "en", "Lublin" },
                    { new Guid("da2e0318-a079-4cb9-ae9d-01eb08dc30b5"), new Guid("827787c2-5977-4b65-87e6-736a252dc443"), "en", "Chernivtsi" },
                    { new Guid("dc2ac65d-429e-47d9-8ce8-6c79cfc88d7d"), new Guid("a903e98b-d863-4595-a405-b4f263d1cdc4"), "uk", "Харків" },
                    { new Guid("dd96ec21-1224-4d82-9dda-270b6bf0c2c3"), new Guid("8b50725c-c16e-4f35-a136-047e9ec018f7"), "en", "Vinnytsia" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("e39a99a3-648f-42d5-a4d5-97152e7a97e7"), new Guid("5a584759-29dc-48bd-91f4-7a7a1124f5b6"), "uk", "Івано-Франківськ" },
                    { new Guid("f2e68e22-8fc0-40da-9d03-572d2ffd1909"), new Guid("8b50725c-c16e-4f35-a136-047e9ec018f7"), "uk", "Вінниця" },
                    { new Guid("f34103a2-519b-43ae-bdfd-dbb9ab923f90"), new Guid("46177a57-7f0b-41e2-a08d-7bb64100968c"), "en", "Chernihiv" },
                    { new Guid("f81dd8b6-cff9-4f52-b18e-9861b256503d"), new Guid("3583680e-2f34-4347-8d09-c362ee0e1bb2"), "en", "Odesa" },
                    { new Guid("f88cdce6-a6e0-48ae-9014-d8f2a475d954"), new Guid("2fbf8f05-d281-4dbc-852c-956dfaa66b61"), "uk", "Рівне" },
                    { new Guid("f9af3577-031d-48bb-aa7c-cb4ac6b788b9"), new Guid("b683b76f-a05c-467c-98d6-f9b25bf46a97"), "uk", "Люблін" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("941d7c0a-0dde-489e-9a2d-0100ecc7e130"), new Guid("8b50725c-c16e-4f35-a136-047e9ec018f7"), new DateTime(2023, 5, 28, 14, 26, 9, 869, DateTimeKind.Local).AddTicks(4737), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Donates_Applications_ApplicationId",
                table: "Donates",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donates_Applications_ApplicationId",
                table: "Donates");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("07363ecb-71f3-4184-a711-cd473c3af550"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("34e8e3b4-3602-463c-ac0c-7267e37f6394"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("85453b53-0cd6-4fbe-8c17-187aa0ae21ba"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("acdcb2b2-02fb-4030-aacf-b9d3a86f93ee"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b3a88d68-09e6-4a16-9a2b-946caef064a0"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("be522fd5-cc6a-4165-b08d-d77fafb3f787"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cceb19d8-f1ef-4c4c-b4bd-26c5d0f155ee"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cf155cee-051e-4904-8553-e5f802d3c032"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d58a7c01-e891-46db-9eff-8fffb40e2b90"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e74af47d-3e3c-4629-bfc2-7204596c1d8c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0153a83f-ea71-42c3-b718-32e67e292145"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("082df4ab-c559-4d08-8623-76538d859476"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0df0a6e5-2c61-496f-abf4-941f6e9c65a0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0f07c8a4-a5e2-4d07-aba6-e63eeca97700"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("131ecd91-8a49-4a10-b0ba-e0f16c41eae5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("325d2207-d396-4c1e-849a-2d21a4f51281"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3eda8853-5d61-4827-abaf-db97779ca4f0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("52de48e9-1dc4-4e57-a94f-2e1fbb1499d9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("57ab02f0-7b54-4b81-a520-a43012a05085"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5acb26ff-8627-4177-a509-00c88040bce0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("667b295f-cbf2-4c62-be6d-9f16441fc9e2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("66875fcd-8f63-4f38-bf39-1788be9cabba"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6b021472-0cac-4c83-8105-e54d3cccd536"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6e3e8ee1-88da-4004-b396-5f6a3a637273"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6f8985b8-9a11-499c-b686-43c88285264a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("744ba161-63af-4040-9baa-1eb28be34582"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("83050420-19e6-4dc6-84b4-8134ed3b8c58"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("89c84fab-7553-472b-b806-7e760a253582"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8b80e892-4e3a-4821-9d8e-ee9f9cad4932"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9609685d-bae7-4a0e-9264-b3b2de8141bf"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9756a4b8-8a8c-4dee-9f85-2490be3f92c6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("993b293a-539c-4630-b032-cdef54bc6462"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9ae00b3d-5eae-4376-98e2-39f65500b2aa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9dac26ff-01b4-45b9-a956-31386219b412"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a2383d06-8504-42dd-8abb-a663a9e8dd0b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a4595e09-cb00-44ba-9d2c-2c5b512450b3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a4a5daae-b54a-4a49-be50-c2408dae78b3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a88dbdfe-04c9-41fe-90e6-be30b6063148"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("af6017f8-03f0-44a6-b2f2-57b799e7351b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b06216a0-e951-4f7a-8a95-d17d80b7f171"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b8e66a80-7d20-4ce5-ae96-635ecb3755de"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bccbd26e-2f68-4e07-876b-9c15a05a919a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bd7bf68b-0eef-4434-a3b4-123f113662b4"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bdd3fd58-ae1b-4f8b-9de2-d365ceb6f0a5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c7361daa-045e-4487-a8b0-de2c1f475b39"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c89984f2-e162-4903-a52f-43caa5e610c9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cc35fe52-9fe3-405d-b72b-14c1a68c0945"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cf2d81ef-5b4e-4ea2-a693-31fd9269b0db"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d6016dcd-5c60-4c3e-ae28-85ae7b047a5b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("da2e0318-a079-4cb9-ae9d-01eb08dc30b5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dc2ac65d-429e-47d9-8ce8-6c79cfc88d7d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dd96ec21-1224-4d82-9dda-270b6bf0c2c3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e39a99a3-648f-42d5-a4d5-97152e7a97e7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f2e68e22-8fc0-40da-9d03-572d2ffd1909"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f34103a2-519b-43ae-bdfd-dbb9ab923f90"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f81dd8b6-cff9-4f52-b18e-9861b256503d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f88cdce6-a6e0-48ae-9014-d8f2a475d954"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f9af3577-031d-48bb-aa7c-cb4ac6b788b9"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("18b07008-ee87-42c1-8f45-6dd2be3e0824"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3743aad5-fc25-4dba-95fd-f2dfa1c021ed"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("88d6e487-f78c-46fb-a084-9678cb8efee5"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e099b482-2aef-4f25-8f3f-6ef023f67dc7"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2276803c-4b1d-4a28-84c8-346d5365df66"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("59dd2315-d166-457c-8cd3-4fd972012a88"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6f5cc9b9-2123-4d01-8b89-98765e3f51d0"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("795d45a6-fe94-4681-bed9-51afd3e2c83d"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9e5ee1b5-04d7-4e28-a122-36ce89f023fb"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a6a15903-80cc-4bf6-89a9-b8b1bde22ca4"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ba131086-3287-4973-beb3-8a22606728cc"));

            migrationBuilder.DeleteData(
                table: "SkillTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c6d8e900-706f-4e91-9d7b-9cc812dadcea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("941d7c0a-0dde-489e-9a2d-0100ecc7e130"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5534bdcc-ae0b-4075-903f-504fecd26b47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cffd041-3f98-4cf9-a151-baa930b7b63c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd4aa92-7723-460a-81d4-62a39469187a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3c27e53-7a00-478d-b9d6-cb5d60d03062"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fabf934e-80e8-42d5-b878-98ec1dfe2ec9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("157d6706-3c85-45e3-bb46-bdf2d44d0fb8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c84b100-3762-46f3-957d-5aee7ef72372"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("293653a4-1773-4d54-9ffc-b8498df8d3f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2fbf8f05-d281-4dbc-852c-956dfaa66b61"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3583680e-2f34-4347-8d09-c362ee0e1bb2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("46177a57-7f0b-41e2-a08d-7bb64100968c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a584759-29dc-48bd-91f4-7a7a1124f5b6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("68f4a226-5e24-446a-a9fb-a8a86d7f939f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7b18ce0f-fadb-43c6-b09d-24122562c055"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("827787c2-5977-4b65-87e6-736a252dc443"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("86493d1d-f4b7-43b3-984b-3c2228ece112"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b50725c-c16e-4f35-a136-047e9ec018f7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8db1b9a2-3e26-44b0-8a72-b8225190e8b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a1a22884-d29a-4fbe-9e4f-0647535266e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a6d477eb-a32f-4cdd-87a4-a850d4f92c79"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a903e98b-d863-4595-a405-b4f263d1cdc4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b683b76f-a05c-467c-98d6-f9b25bf46a97"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c25f3c4a-2e13-4844-beb1-3b2a3b46c0a4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c4940670-f991-4968-985c-c3d517dcd114"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c9237575-d028-406e-a7c7-9c5f5e53e87b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f36abbad-e3e9-4e44-8287-9607f7bc13ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f561b6c5-de41-46b1-951c-5f87f3316b37"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6766f2b-0fc2-466b-b91f-9732af19dd97"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb2d6b2a-aa74-4332-8382-2c1814b799ee"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0d280e1f-998f-49a7-9b4c-48cb1bbf5274"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("137647b7-f42a-46a0-984b-9cfd457e1aba"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("83f1af7b-d18e-42d6-b15c-e2c929fb596c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bf83c741-70e5-4ddf-b597-2e4cd077c914"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b7b2dda-75a2-4b79-b846-b1bcafc695ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af84322e-59e1-4c58-8994-6d37914b0dc4"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationId",
                table: "Donates",
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
                    { new Guid("6ba5d2c2-2fb6-4ef4-bda6-94df28f03169"), "education" },
                    { new Guid("73405840-06c7-4169-ad1c-a7e68c67f1dc"), "sports and physical culture" },
                    { new Guid("7486617d-4d74-4187-b567-dfa86159ebe0"), "social programs" },
                    { new Guid("b1eb1bf2-06d0-4aa7-9599-6c7861d49bcc"), "culture and art" },
                    { new Guid("e279e8e5-93c1-4cd8-86ca-28e79b0830b1"), "health care" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"), "pl" },
                    { new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0a27f1ba-d94d-4e1c-ab59-99952e96764b"), "building" },
                    { new Guid("3d2c6f42-1943-4f69-b501-79de78afe8af"), "psychology" },
                    { new Guid("a34e7e3a-336a-4d76-adb3-fcec13a5e1f6"), "cooking" },
                    { new Guid("a550ef1c-5eb1-4341-ba58-6cafa27c003a"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "DescriptionCategory", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("012951da-a01f-428a-95de-982c91f292a5"), new Guid("b1eb1bf2-06d0-4aa7-9599-6c7861d49bcc"), " ", "en", "culture and art" },
                    { new Guid("181c9ab8-29be-45ef-9844-f8967c62895b"), new Guid("b1eb1bf2-06d0-4aa7-9599-6c7861d49bcc"), " ", "uk", "культура та мистецтво" },
                    { new Guid("23e967a2-ea88-4c5d-acd8-03583beb3d8a"), new Guid("7486617d-4d74-4187-b567-dfa86159ebe0"), " ", "en", "social programs" },
                    { new Guid("25785996-28d3-4d03-972e-8861d81e949b"), new Guid("73405840-06c7-4169-ad1c-a7e68c67f1dc"), " ", "en", "sport and physical culture" },
                    { new Guid("340a9e95-f02e-49bc-bc23-de17c4c60b40"), new Guid("7486617d-4d74-4187-b567-dfa86159ebe0"), " ", "uk", "соціальні програми" },
                    { new Guid("66004077-e002-4605-9c5a-3616a6b8a21c"), new Guid("e279e8e5-93c1-4cd8-86ca-28e79b0830b1"), " ", "en", "health care" },
                    { new Guid("69acc5f5-b7a5-4cb9-8d96-8d4c6a7e34e5"), new Guid("73405840-06c7-4169-ad1c-a7e68c67f1dc"), " ", "uk", "спорт та фізична культура" },
                    { new Guid("94c1c6e0-e960-4956-a65f-13b9eb30082c"), new Guid("e279e8e5-93c1-4cd8-86ca-28e79b0830b1"), " ", "uk", "охорона здоров'я" },
                    { new Guid("94ef0a2e-4835-42a2-8c58-5f435def10bc"), new Guid("6ba5d2c2-2fb6-4ef4-bda6-94df28f03169"), " ", "uk", "освіта" },
                    { new Guid("e5702365-fd30-494c-922b-107c3434a3fa"), new Guid("6ba5d2c2-2fb6-4ef4-bda6-94df28f03169"), " ", "en", "education" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("249367a5-add6-4f1c-a803-d55e45e8d4a6"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "pol" },
                    { new Guid("35e4c480-9cf5-4ec7-bff8-fb8d870203ef"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "kher" },
                    { new Guid("36b5f355-fc4f-4ea0-9fc0-d6071b4d4122"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "zhy" },
                    { new Guid("41a4f995-6e36-4e71-8c59-87235b379f2a"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "ky" },
                    { new Guid("4b0cbfb4-eaea-40ed-adf0-9bdb57168221"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "ri" },
                    { new Guid("5738bfef-0918-4cc7-b667-f07fb01773f6"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "vi" },
                    { new Guid("5ab3e6d9-c715-4d83-a126-d31e55fc62f4"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "chh" },
                    { new Guid("6e50a4de-65fb-4321-95d4-2f6eef3ab701"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "khar" },
                    { new Guid("7e96c1e2-0280-4641-8e62-c93b14be6276"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "od" },
                    { new Guid("8757a185-287b-4cef-b085-9a62f36f0b64"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "chv" },
                    { new Guid("9019b793-227e-44b9-b300-64cc14e15c26"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "lv" },
                    { new Guid("932a31d2-ae38-419a-8c47-6f02f81aa14b"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "zp" },
                    { new Guid("97ec3f0d-f4f0-4604-b75a-3854c8a41ad9"), new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"), "var" },
                    { new Guid("a1c3b944-151f-4a42-877c-92b663bcb748"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "ter" },
                    { new Guid("a75777ab-9482-469e-8002-383671fd3365"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "khm" },
                    { new Guid("b1ebcc5b-78ae-485c-9d1f-bba6e57aee31"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "uzh" },
                    { new Guid("cb972141-1a48-4079-993d-bf9f3c14e01e"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "my" },
                    { new Guid("d1376531-b118-411e-aaa1-6bd4b20ecd9a"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "kr" },
                    { new Guid("d52852a1-db2b-4347-bbf3-3407a589ea5f"), new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"), "lub" },
                    { new Guid("d604c9a2-4168-467e-920a-c827919ebfc7"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "lut" },
                    { new Guid("e064f96b-ef7f-4b5a-8cdd-c60cd020685f"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "su" },
                    { new Guid("e11ea064-7adb-4eed-a71d-434629a6fdd1"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "chk" },
                    { new Guid("e76dab51-bda2-4f4c-a556-3eb6aa2b092d"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "if" },
                    { new Guid("e98303f4-5fe9-4047-823c-b8db96e54a40"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "dn" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0540d890-7e59-4544-9f3f-82d4d5ae560f"), new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"), "uk", "Польша" },
                    { new Guid("06f4c740-2f50-4922-bcc6-2808e919be1b"), new Guid("312b6f67-c531-40c3-a675-ec1bc9b7691f"), "en", "Poland" },
                    { new Guid("71ebcb95-a103-48d3-84d1-52ec8eb88d69"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "en", "Ukraine" },
                    { new Guid("80218614-9035-4251-b1a7-15447cb1e3cb"), new Guid("73a58b0f-fec7-435e-a547-f7f59e260e0a"), "uk", "Україна" }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("17479483-8c69-4899-a6c7-796866c4a9c8"), "uk", "кулінарія", new Guid("a34e7e3a-336a-4d76-adb3-fcec13a5e1f6") },
                    { new Guid("237e5dbc-f065-4e87-a92e-f6c01488b2ce"), "uk", "будівництво", new Guid("0a27f1ba-d94d-4e1c-ab59-99952e96764b") },
                    { new Guid("46a70530-bbb3-4cb8-8aaf-8902b151f3a3"), "en", "building", new Guid("0a27f1ba-d94d-4e1c-ab59-99952e96764b") },
                    { new Guid("56df03fc-2b61-4b3b-9f8a-014eea6e5692"), "en", "medicine", new Guid("a550ef1c-5eb1-4341-ba58-6cafa27c003a") }
                });

            migrationBuilder.InsertData(
                table: "SkillTranslations",
                columns: new[] { "Id", "Language", "Name", "SkillId" },
                values: new object[,]
                {
                    { new Guid("7d4a1ff5-f46a-425f-b4d7-de6e1ed8fdf1"), "en", "psychology", new Guid("3d2c6f42-1943-4f69-b501-79de78afe8af") },
                    { new Guid("a4954a9e-d86a-4292-a9b0-7645345f3d7a"), "uk", "психологія", new Guid("3d2c6f42-1943-4f69-b501-79de78afe8af") },
                    { new Guid("aec25848-a151-4761-9757-ab7ee24c8fb6"), "en", "cooking", new Guid("a34e7e3a-336a-4d76-adb3-fcec13a5e1f6") },
                    { new Guid("c8e98ce4-cf7a-4c31-9a69-9cd7b5f10cce"), "uk", "медицина", new Guid("a550ef1c-5eb1-4341-ba58-6cafa27c003a") }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0533e4eb-7f9e-42d5-bf85-1b81b19fc302"), new Guid("e11ea064-7adb-4eed-a71d-434629a6fdd1"), "en", "Cherkasy" },
                    { new Guid("07f30d7f-ef06-4364-91c1-0af1d0a1f474"), new Guid("b1ebcc5b-78ae-485c-9d1f-bba6e57aee31"), "en", "Uzhhorod" },
                    { new Guid("09d30c5b-d6eb-43ac-a5bf-8fcd97ebbfcc"), new Guid("9019b793-227e-44b9-b300-64cc14e15c26"), "en", "Lviv" },
                    { new Guid("10eca06f-28b7-4a24-9d84-5540e41a8867"), new Guid("d52852a1-db2b-4347-bbf3-3407a589ea5f"), "en", "Lublin" },
                    { new Guid("180b7857-0152-4588-9dda-1ba25540ebfa"), new Guid("97ec3f0d-f4f0-4604-b75a-3854c8a41ad9"), "en", "Varshava" },
                    { new Guid("1e0a64e7-6fbc-4285-8354-4e815384d0e6"), new Guid("e064f96b-ef7f-4b5a-8cdd-c60cd020685f"), "en", "Sumy" },
                    { new Guid("246501c4-5693-49cc-930c-e65bba713377"), new Guid("a75777ab-9482-469e-8002-383671fd3365"), "en", "Khmelnytskyi" },
                    { new Guid("2ccf8f17-ff31-4072-80fc-5bf66cc20c8e"), new Guid("97ec3f0d-f4f0-4604-b75a-3854c8a41ad9"), "uk", "Варшава" },
                    { new Guid("2fec43be-ea65-4a24-b1dc-4d8edfeab3d5"), new Guid("6e50a4de-65fb-4321-95d4-2f6eef3ab701"), "uk", "Харків" },
                    { new Guid("358ea2d7-c256-416f-813c-6a8fdd5056b5"), new Guid("7e96c1e2-0280-4641-8e62-c93b14be6276"), "uk", "Одеса" },
                    { new Guid("36d36660-91e6-4151-bd05-2a09e7f9a0e9"), new Guid("35e4c480-9cf5-4ec7-bff8-fb8d870203ef"), "en", "Kherson" },
                    { new Guid("3a84a5ae-9952-496d-ba19-532df3927dc2"), new Guid("35e4c480-9cf5-4ec7-bff8-fb8d870203ef"), "uk", "Херсон" },
                    { new Guid("47eecf6c-4840-4bbb-9043-9bcbb81a3838"), new Guid("5ab3e6d9-c715-4d83-a126-d31e55fc62f4"), "en", "Chernihiv" },
                    { new Guid("4a20c207-07b8-4320-bfa6-8622d55de0a2"), new Guid("36b5f355-fc4f-4ea0-9fc0-d6071b4d4122"), "en", "Zhytomyr" },
                    { new Guid("4e7b4fa5-53f8-4be0-8d76-9cca89131d6e"), new Guid("e76dab51-bda2-4f4c-a556-3eb6aa2b092d"), "en", "Ivano-Frankivsk" },
                    { new Guid("4ec68777-8a20-47a6-b979-2fd2d2288979"), new Guid("932a31d2-ae38-419a-8c47-6f02f81aa14b"), "uk", "Запоріжжя" },
                    { new Guid("561461bd-016b-46c0-825e-149a80d7226b"), new Guid("a1c3b944-151f-4a42-877c-92b663bcb748"), "en", "Ternopil" },
                    { new Guid("58d03d28-7bca-4ed0-857d-e73db05cb021"), new Guid("932a31d2-ae38-419a-8c47-6f02f81aa14b"), "en", "Zaporizhzhia" },
                    { new Guid("5e074313-d3c2-48cd-bee5-68559fd72d8f"), new Guid("d1376531-b118-411e-aaa1-6bd4b20ecd9a"), "en", "Kropyvnytskyi" },
                    { new Guid("60ea73f7-5de2-4748-9376-157ed85c9edb"), new Guid("7e96c1e2-0280-4641-8e62-c93b14be6276"), "en", "Odesa" },
                    { new Guid("64a68285-649d-4555-9b94-47bb2682337f"), new Guid("8757a185-287b-4cef-b085-9a62f36f0b64"), "en", "Chernivtsi" },
                    { new Guid("655295a9-3617-4884-9fe7-7b6a786f2ecb"), new Guid("8757a185-287b-4cef-b085-9a62f36f0b64"), "uk", "Чернівці" },
                    { new Guid("6772ce1b-7f87-4814-b296-fe4056c66212"), new Guid("e76dab51-bda2-4f4c-a556-3eb6aa2b092d"), "uk", "Івано-Франківськ" },
                    { new Guid("67a1a5c3-e493-44f0-9fcf-96b1ff243da4"), new Guid("5738bfef-0918-4cc7-b667-f07fb01773f6"), "uk", "Вінниця" },
                    { new Guid("6b8ba8fa-2c26-4463-baba-56b96d6654fa"), new Guid("41a4f995-6e36-4e71-8c59-87235b379f2a"), "en", "Kyiv" },
                    { new Guid("6e715c41-8725-445a-957b-237a47cc7ccc"), new Guid("5ab3e6d9-c715-4d83-a126-d31e55fc62f4"), "uk", "Чернігів" },
                    { new Guid("80d0b99b-c5ac-4374-a86e-69af2e1c04a3"), new Guid("249367a5-add6-4f1c-a803-d55e45e8d4a6"), "uk", "Полтава" },
                    { new Guid("81526597-92be-4717-9528-c88e4783c373"), new Guid("e11ea064-7adb-4eed-a71d-434629a6fdd1"), "uk", "Черкаси" },
                    { new Guid("81da23bc-b504-40aa-beb1-f93cb19ec2a3"), new Guid("36b5f355-fc4f-4ea0-9fc0-d6071b4d4122"), "uk", "Житомир" },
                    { new Guid("82b412d3-e1da-4e7f-86e1-61dcb9cdb3a9"), new Guid("e98303f4-5fe9-4047-823c-b8db96e54a40"), "en", "Dnipro" },
                    { new Guid("9290b6d7-3168-43bb-9b38-add1ad9352d5"), new Guid("249367a5-add6-4f1c-a803-d55e45e8d4a6"), "en", "Poltava" },
                    { new Guid("94da7a9a-27ca-4dc7-8e53-40f04402a070"), new Guid("e98303f4-5fe9-4047-823c-b8db96e54a40"), "uk", "Дніпро" },
                    { new Guid("9b9cfae8-6db1-4d6d-9e7d-070a6fb9ac7a"), new Guid("cb972141-1a48-4079-993d-bf9f3c14e01e"), "uk", "Миколаїв" },
                    { new Guid("9ee961e3-51fb-4884-b5f3-ddc11f9a01fe"), new Guid("d604c9a2-4168-467e-920a-c827919ebfc7"), "en", "Lutsk" },
                    { new Guid("a38aecd0-2d3a-4d61-9a9c-2c973522f77d"), new Guid("a1c3b944-151f-4a42-877c-92b663bcb748"), "uk", "Тернопіль" },
                    { new Guid("a442a2da-eda8-41e0-b271-f97d1952bb4f"), new Guid("41a4f995-6e36-4e71-8c59-87235b379f2a"), "uk", "Київ" },
                    { new Guid("a9f8aeeb-08db-47b4-ba07-331700b1dfe4"), new Guid("d604c9a2-4168-467e-920a-c827919ebfc7"), "uk", "Луцьк" },
                    { new Guid("aaf920d1-297d-42de-837b-d2e6d2417d10"), new Guid("4b0cbfb4-eaea-40ed-adf0-9bdb57168221"), "uk", "Рівне" },
                    { new Guid("c275a99d-8c37-4ffa-85dc-be0967eb150b"), new Guid("4b0cbfb4-eaea-40ed-adf0-9bdb57168221"), "en", "Rivne" },
                    { new Guid("c63d2d44-dc99-4408-8308-297bd09cc46c"), new Guid("6e50a4de-65fb-4321-95d4-2f6eef3ab701"), "en", "Kharkiv" },
                    { new Guid("cbcaaf69-bd2c-416c-8919-0ac96b20c484"), new Guid("a75777ab-9482-469e-8002-383671fd3365"), "uk", "Хмельницький" },
                    { new Guid("d24212a7-aa33-4005-a1a8-005d7ed0956a"), new Guid("5738bfef-0918-4cc7-b667-f07fb01773f6"), "en", "Vinnytsia" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d9b4ef54-8361-472d-b731-15e5e8abb506"), new Guid("cb972141-1a48-4079-993d-bf9f3c14e01e"), "en", "Mykolaiv" },
                    { new Guid("e344eb3a-d234-4e99-9b0f-880aac8ef2a6"), new Guid("b1ebcc5b-78ae-485c-9d1f-bba6e57aee31"), "uk", "Ужгород" },
                    { new Guid("ed6207eb-530e-4cfa-8a3a-32d9e4202285"), new Guid("d1376531-b118-411e-aaa1-6bd4b20ecd9a"), "uk", "Кропивницький" },
                    { new Guid("f2e91a2d-7c20-4d68-a9e5-2de15b657bfd"), new Guid("9019b793-227e-44b9-b300-64cc14e15c26"), "uk", "Львів" },
                    { new Guid("f4b247d5-875f-4ead-8b62-db3b48786acc"), new Guid("d52852a1-db2b-4347-bbf3-3407a589ea5f"), "uk", "Люблін" },
                    { new Guid("f9c5c484-76bc-4de6-bb3d-962b0b03f498"), new Guid("e064f96b-ef7f-4b5a-8cdd-c60cd020685f"), "uk", "Суми" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "DateOfBirth", "FirstName", "LastName", "Login", "Password", "Phone", "Role" },
                values: new object[] { new Guid("2516916c-614b-493a-a819-a0f58527a71b"), new Guid("5738bfef-0918-4cc7-b667-f07fb01773f6"), new DateTime(2023, 5, 25, 22, 42, 37, 388, DateTimeKind.Local).AddTicks(947), "the first", "admin", "ourfirstadmin", "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=", "+11111111111", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Donates_Applications_ApplicationId",
                table: "Donates",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

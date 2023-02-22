using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class NewLocationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("00a9fc0d-def9-41f0-aaf4-0045211d5de3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("00cd689c-26c3-4165-a259-91e44e0d6cb9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0449b008-16e0-4fc7-b571-76e30f8498d6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7f027fa1-ab00-4fc9-8015-9a22bd375d73"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dbf55a7c-51a5-40f5-bc4e-175697f259a2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dda40359-da4a-410d-857f-87bc6a9f8ef9"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5c938f1d-cdbd-4614-862a-d7f0988be769"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("872814a0-29e5-4956-981e-c82afea72373"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("89c38fd0-6582-4cf8-b58f-d7c21363d97b"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f83da9a9-268b-43ec-85c7-1aaefdaf8916"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0d6ed6a7-a4b2-45ae-90fb-b58a038955c0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("22415ac9-c010-48b4-b14d-9d9f6436a726"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("124ceceb-4954-4b01-a10d-6ed771486377"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("35fe87a7-e5ea-40a3-b753-ba50359cb894"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4cd33d39-183d-47d0-99e6-0dbd6d501304"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a1b2f63-f598-4772-ba60-0419e87b1ac0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("4538b535-cab1-4c4b-a70b-7ac8cce8c693"), "pl" },
                    { new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("5d917156-bacd-4803-b594-35b0ede036bc"), "medicine" },
                    { new Guid("be8d4b9c-f535-4b06-9120-82a637ee04ba"), "cook" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("47313d0e-ab87-4ecb-b4ad-ab29c3c7cdb7"), new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"), "ha" },
                    { new Guid("5e9eca71-da68-442d-a64c-d080e825507a"), new Guid("4538b535-cab1-4c4b-a70b-7ac8cce8c693"), "var" },
                    { new Guid("a5401c4e-217c-4f4c-a63a-9f5d46132aba"), new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"), "zp" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("5a17cba1-cc30-4c65-9c8d-a0e29929d3c5"), new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"), "uk", "Україна" },
                    { new Guid("5d364643-e213-43d5-8aed-9da48af1e7a8"), new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"), "en", "Ukraine" },
                    { new Guid("f1c456dc-4824-42d5-9271-1f1022c9c713"), new Guid("4538b535-cab1-4c4b-a70b-7ac8cce8c693"), "en", "Poland" },
                    { new Guid("ff270300-7684-45a1-b9d1-65552c6e03f1"), new Guid("4538b535-cab1-4c4b-a70b-7ac8cce8c693"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("2836b2dc-5892-499e-ad7a-385e8fc00015"), new Guid("47313d0e-ab87-4ecb-b4ad-ab29c3c7cdb7"), "en", "Khar" },
                    { new Guid("7152853c-7940-4d2f-acbb-37ffe7fd3f73"), new Guid("a5401c4e-217c-4f4c-a63a-9f5d46132aba"), "uk", "Зап" },
                    { new Guid("81f37143-48ee-417c-8b7d-00e3a2d6c0da"), new Guid("5e9eca71-da68-442d-a64c-d080e825507a"), "uk", "Варшава" },
                    { new Guid("bd1de09b-764f-4091-991f-1845876f1a13"), new Guid("a5401c4e-217c-4f4c-a63a-9f5d46132aba"), "en", "Zap" },
                    { new Guid("e0a09ca3-82e3-4c55-b0d9-774549dca60f"), new Guid("5e9eca71-da68-442d-a64c-d080e825507a"), "en", "Varshava" },
                    { new Guid("fc4b29de-118e-461d-8b77-ed48539a7a2f"), new Guid("47313d0e-ab87-4ecb-b4ad-ab29c3c7cdb7"), "uk", "Харків" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2836b2dc-5892-499e-ad7a-385e8fc00015"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7152853c-7940-4d2f-acbb-37ffe7fd3f73"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("81f37143-48ee-417c-8b7d-00e3a2d6c0da"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bd1de09b-764f-4091-991f-1845876f1a13"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e0a09ca3-82e3-4c55-b0d9-774549dca60f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fc4b29de-118e-461d-8b77-ed48539a7a2f"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5a17cba1-cc30-4c65-9c8d-a0e29929d3c5"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5d364643-e213-43d5-8aed-9da48af1e7a8"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f1c456dc-4824-42d5-9271-1f1022c9c713"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ff270300-7684-45a1-b9d1-65552c6e03f1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5d917156-bacd-4803-b594-35b0ede036bc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("be8d4b9c-f535-4b06-9120-82a637ee04ba"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("47313d0e-ab87-4ecb-b4ad-ab29c3c7cdb7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e9eca71-da68-442d-a64c-d080e825507a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a5401c4e-217c-4f4c-a63a-9f5d46132aba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4538b535-cab1-4c4b-a70b-7ac8cce8c693"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75cd88ac-5f21-476e-af21-1070eab76dbc"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISO" },
                values: new object[,]
                {
                    { new Guid("4a1b2f63-f598-4772-ba60-0419e87b1ac0"), "pl" },
                    { new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0d6ed6a7-a4b2-45ae-90fb-b58a038955c0"), "cook" },
                    { new Guid("22415ac9-c010-48b4-b14d-9d9f6436a726"), "medicine" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("124ceceb-4954-4b01-a10d-6ed771486377"), new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"), "ha" },
                    { new Guid("35fe87a7-e5ea-40a3-b753-ba50359cb894"), new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"), "zp" },
                    { new Guid("4cd33d39-183d-47d0-99e6-0dbd6d501304"), new Guid("4a1b2f63-f598-4772-ba60-0419e87b1ac0"), "var" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("5c938f1d-cdbd-4614-862a-d7f0988be769"), new Guid("4a1b2f63-f598-4772-ba60-0419e87b1ac0"), "uk", "Польша" },
                    { new Guid("872814a0-29e5-4956-981e-c82afea72373"), new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"), "uk", "Україна" },
                    { new Guid("89c38fd0-6582-4cf8-b58f-d7c21363d97b"), new Guid("4dd72492-4b71-419a-ab7a-ef9c8d68bcca"), "en", "Ukraine" },
                    { new Guid("f83da9a9-268b-43ec-85c7-1aaefdaf8916"), new Guid("4a1b2f63-f598-4772-ba60-0419e87b1ac0"), "en", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("00a9fc0d-def9-41f0-aaf4-0045211d5de3"), new Guid("35fe87a7-e5ea-40a3-b753-ba50359cb894"), "en", "Zap" },
                    { new Guid("00cd689c-26c3-4165-a259-91e44e0d6cb9"), new Guid("124ceceb-4954-4b01-a10d-6ed771486377"), "uk", "Харків" },
                    { new Guid("0449b008-16e0-4fc7-b571-76e30f8498d6"), new Guid("4cd33d39-183d-47d0-99e6-0dbd6d501304"), "uk", "Варшава" },
                    { new Guid("7f027fa1-ab00-4fc9-8015-9a22bd375d73"), new Guid("4cd33d39-183d-47d0-99e6-0dbd6d501304"), "en", "Varshava" },
                    { new Guid("dbf55a7c-51a5-40f5-bc4e-175697f259a2"), new Guid("124ceceb-4954-4b01-a10d-6ed771486377"), "en", "Khar" },
                    { new Guid("dda40359-da4a-410d-857f-87bc6a9f8ef9"), new Guid("35fe87a7-e5ea-40a3-b753-ba50359cb894"), "uk", "Зап" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class TranslationCountryCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("07760e6a-3596-4d91-af1c-f000b48e8943"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0ad5ac42-01e7-4362-9da9-311fc60afcbd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("771155b1-372a-4390-950e-22d91bbb53ac"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7bd3a1bb-35ae-49b0-8704-1a089ecd959d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("f63c3e90-9d55-4970-9e3a-1648951e32c5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fadef7b5-6c84-4969-bd1e-decc439735fd"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("36344907-59b1-4149-9d24-25967cc41341"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("43662264-fb01-42c5-91d7-73439d877323"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d2f3d0eb-33a7-47ed-a551-bb4abad42393"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d7c6d5ea-4319-46ed-ad46-02e4825c71a3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("691058e6-ed12-4815-b1a2-2052c36b11c8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d713f8bb-3be7-49e3-a51c-db8077127049"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c216da41-067d-42e6-9803-28edd811717c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2cf303e5-131a-4786-a715-e47d585c8103"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("2cf303e5-131a-4786-a715-e47d585c8103"), "pl" },
                    { new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("691058e6-ed12-4815-b1a2-2052c36b11c8"), "medicine" },
                    { new Guid("d713f8bb-3be7-49e3-a51c-db8077127049"), "cook" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"), new Guid("2cf303e5-131a-4786-a715-e47d585c8103"), "var" },
                    { new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"), new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"), "ha" },
                    { new Guid("c216da41-067d-42e6-9803-28edd811717c"), new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"), "zp" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("36344907-59b1-4149-9d24-25967cc41341"), new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"), "en", "Ukraine" },
                    { new Guid("43662264-fb01-42c5-91d7-73439d877323"), new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"), "uk", "Україна" },
                    { new Guid("d2f3d0eb-33a7-47ed-a551-bb4abad42393"), new Guid("2cf303e5-131a-4786-a715-e47d585c8103"), "uk", "Польша" },
                    { new Guid("d7c6d5ea-4319-46ed-ad46-02e4825c71a3"), new Guid("2cf303e5-131a-4786-a715-e47d585c8103"), "en", "Poland" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("07760e6a-3596-4d91-af1c-f000b48e8943"), new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"), "uk", "Варшава" },
                    { new Guid("0ad5ac42-01e7-4362-9da9-311fc60afcbd"), new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"), "uk", "Харків" },
                    { new Guid("771155b1-372a-4390-950e-22d91bbb53ac"), new Guid("c216da41-067d-42e6-9803-28edd811717c"), "en", "Zap" },
                    { new Guid("7bd3a1bb-35ae-49b0-8704-1a089ecd959d"), new Guid("c216da41-067d-42e6-9803-28edd811717c"), "uk", "Зап" },
                    { new Guid("f63c3e90-9d55-4970-9e3a-1648951e32c5"), new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"), "en", "Varshava" },
                    { new Guid("fadef7b5-6c84-4969-bd1e-decc439735fd"), new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"), "en", "Khar" }
                });
        }
    }
}

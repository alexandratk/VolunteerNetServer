using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DefaultdataLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"), "pl" },
                    { new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "uk" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0e263e8e-3e11-4c06-a9a3-9d7c43a67ab2"), "medicine" },
                    { new Guid("35ace4d2-6eba-4914-913b-ddd105de8da4"), "cook" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "ISO" },
                values: new object[,]
                {
                    { new Guid("089d79e9-e533-4099-b531-4ef9c322a7e5"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "lut" },
                    { new Guid("10548d21-4b1d-415d-b98b-f060d3034635"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "chk" },
                    { new Guid("141068d2-e188-4bf4-9d6f-64943bb343ac"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "od" },
                    { new Guid("1d061e77-6378-4159-8968-3e9504c40a52"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "su" },
                    { new Guid("42206872-36b7-4979-af0a-a166cf4740be"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "vi" },
                    { new Guid("43b7d673-dcf2-46a3-9567-25ff782bdcb1"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "my" },
                    { new Guid("4bc6769a-12d9-4f94-a14b-f92e2288e8da"), new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"), "var" },
                    { new Guid("4c53d37e-9e9a-4719-b928-835bba74ec7c"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "zp" },
                    { new Guid("545f18c0-e7e0-4909-b749-e68eb86bdfd5"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "dn" },
                    { new Guid("54baa347-8b04-47a1-ab6f-fa720b9b7cd5"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "khar" },
                    { new Guid("5b858e4f-b097-4c77-8414-5a1b4f95bfbb"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "chv" },
                    { new Guid("5d730626-a1c0-4640-9dcb-221248425f51"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "ky" },
                    { new Guid("7666b9e7-7a74-48c2-833a-ebea6b92494e"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "ri" },
                    { new Guid("87a610fa-0314-4346-a0c5-d7185a3cc147"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "zhy" },
                    { new Guid("883aa240-b9a7-47d7-8cf7-d9c8574c8875"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "kr" },
                    { new Guid("95fade87-f693-445e-b16d-2017c4734a0d"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "ter" },
                    { new Guid("a4acf92e-941e-44a7-9648-cdc90defd393"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "khm" },
                    { new Guid("ac9ea5b2-5ba5-43fb-b95d-154f9eebc4c8"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "uzh" },
                    { new Guid("afe68acc-334a-492e-9c6f-18c69d563867"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "pol" },
                    { new Guid("bd8de84d-b962-4e2b-a094-e4411ee8c2c8"), new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"), "lub" },
                    { new Guid("c0d5b96c-57dd-4655-a696-a25813d3b801"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "chh" },
                    { new Guid("d1394a08-6508-4cbd-9643-7a338ee128f9"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "kher" },
                    { new Guid("dd5d3e25-4f7c-44b1-b6e0-edc428e984ff"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "if" },
                    { new Guid("de8a94a9-cddb-47bd-bf1b-b17e4ef292cc"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "lv" }
                });

            migrationBuilder.InsertData(
                table: "CountryTranslations",
                columns: new[] { "Id", "CountryId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("0bbb7e28-b1c1-4ae1-a387-34fefdce95e6"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "uk", "Україна" },
                    { new Guid("3cd6f454-e48b-4c8b-b69c-169baed79c91"), new Guid("58c88726-e32e-4239-92a7-3b0474fac235"), "en", "Ukraine" },
                    { new Guid("8fd4e5a9-569d-4c6e-b346-abd647d442e2"), new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"), "en", "Poland" },
                    { new Guid("fb789f54-80a8-4476-ba73-b33b329fd882"), new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"), "uk", "Польша" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("186aa52c-c83c-4aad-8cf5-d11f130d9e0d"), new Guid("1d061e77-6378-4159-8968-3e9504c40a52"), "uk", "Суми" },
                    { new Guid("18a87db2-878a-412e-9d73-c943f8d0484e"), new Guid("42206872-36b7-4979-af0a-a166cf4740be"), "uk", "Вінниця" },
                    { new Guid("249dce4c-31a4-4ccb-a51e-c128cd665eb7"), new Guid("4c53d37e-9e9a-4719-b928-835bba74ec7c"), "en", "Zaporizhzhia" },
                    { new Guid("289137e0-a5bb-4532-b8cc-c35b4a0cf4fd"), new Guid("a4acf92e-941e-44a7-9648-cdc90defd393"), "uk", "Хмельницький" },
                    { new Guid("2c60b36f-0b66-4834-9351-c8343112f666"), new Guid("10548d21-4b1d-415d-b98b-f060d3034635"), "uk", "Черкаси" },
                    { new Guid("2d7f990a-ed4b-4767-9bbc-303e4011ce63"), new Guid("ac9ea5b2-5ba5-43fb-b95d-154f9eebc4c8"), "en", "Uzhhorod" },
                    { new Guid("321ba799-d34f-489b-9bd7-c9c1b9149b3f"), new Guid("5b858e4f-b097-4c77-8414-5a1b4f95bfbb"), "en", "Chernivtsi" },
                    { new Guid("3733a32c-a897-448b-a36b-2bd4c2bcaa87"), new Guid("bd8de84d-b962-4e2b-a094-e4411ee8c2c8"), "uk", "Люблін" },
                    { new Guid("45c9f3a6-f371-431b-94d0-6aa3a22c9626"), new Guid("5b858e4f-b097-4c77-8414-5a1b4f95bfbb"), "uk", "Чернівці" },
                    { new Guid("507ae7fc-f10d-494f-a4b2-c2213bdfe53a"), new Guid("afe68acc-334a-492e-9c6f-18c69d563867"), "uk", "Полтава" },
                    { new Guid("55769830-704e-47f4-ab64-027413ea3115"), new Guid("95fade87-f693-445e-b16d-2017c4734a0d"), "en", "Ternopil" },
                    { new Guid("5b6111cf-db3e-4698-9868-df9aa33a403e"), new Guid("a4acf92e-941e-44a7-9648-cdc90defd393"), "en", "Khmelnytskyi" },
                    { new Guid("5d96e81a-8bf7-4930-9eb0-97551085f80b"), new Guid("4c53d37e-9e9a-4719-b928-835bba74ec7c"), "uk", "Запоріжжя" },
                    { new Guid("60886a7a-5327-4a9e-b0a0-ce7e5411de41"), new Guid("10548d21-4b1d-415d-b98b-f060d3034635"), "en", "Cherkasy" },
                    { new Guid("6aa2fae9-ddb3-4632-8b53-236ad059a95e"), new Guid("4bc6769a-12d9-4f94-a14b-f92e2288e8da"), "uk", "Варшава" },
                    { new Guid("6df95ec8-2826-4ef5-8e69-6b6f96061714"), new Guid("43b7d673-dcf2-46a3-9567-25ff782bdcb1"), "uk", "Миколаїв" },
                    { new Guid("6f4a11a7-f15b-49e1-ba6c-0d79eb134b3d"), new Guid("54baa347-8b04-47a1-ab6f-fa720b9b7cd5"), "uk", "Харків" },
                    { new Guid("7092094a-d8a7-42e6-ac4d-f166726c1e0f"), new Guid("bd8de84d-b962-4e2b-a094-e4411ee8c2c8"), "en", "Lublin" },
                    { new Guid("71e520a9-9e9a-4c01-93b0-c95b826401b5"), new Guid("42206872-36b7-4979-af0a-a166cf4740be"), "en", "Vinnytsia" },
                    { new Guid("729843d3-36d8-4dc2-aa38-93e00f6732cc"), new Guid("43b7d673-dcf2-46a3-9567-25ff782bdcb1"), "en", "Mykolaiv" },
                    { new Guid("73aad800-4dfc-4e9b-8eb8-8f5e194539e3"), new Guid("089d79e9-e533-4099-b531-4ef9c322a7e5"), "uk", "Луцьк" },
                    { new Guid("79c9ec0b-c3e9-4bee-9164-982b472ce6c2"), new Guid("87a610fa-0314-4346-a0c5-d7185a3cc147"), "uk", "Житомир" },
                    { new Guid("7e07c44e-1c92-43f9-9ef1-b56ad69c269e"), new Guid("d1394a08-6508-4cbd-9643-7a338ee128f9"), "en", "Kherson" },
                    { new Guid("86cd4e81-812b-4123-83ab-229969a9eb70"), new Guid("dd5d3e25-4f7c-44b1-b6e0-edc428e984ff"), "uk", "Івано-Франківськ" },
                    { new Guid("87b3273d-5225-4ba6-8521-19d2f8d2dc2a"), new Guid("141068d2-e188-4bf4-9d6f-64943bb343ac"), "en", "Odesa" },
                    { new Guid("92eb9371-6e8f-4d0d-8133-07bcdb702434"), new Guid("7666b9e7-7a74-48c2-833a-ebea6b92494e"), "uk", "Рівне" },
                    { new Guid("92f76a7d-4fca-459e-a37a-99b2a9fa54b9"), new Guid("afe68acc-334a-492e-9c6f-18c69d563867"), "en", "Poltava" },
                    { new Guid("9726f64f-f590-42a7-8af0-a5f6f7eaf223"), new Guid("5d730626-a1c0-4640-9dcb-221248425f51"), "en", "Kyiv" },
                    { new Guid("9830aa4e-3aa1-4e6b-97a6-09cce651212c"), new Guid("c0d5b96c-57dd-4655-a696-a25813d3b801"), "en", "Chernihiv" },
                    { new Guid("a074273d-4c57-4d91-85bf-8a730a4853fc"), new Guid("545f18c0-e7e0-4909-b749-e68eb86bdfd5"), "en", "Dnipro" },
                    { new Guid("af82da64-76d1-4135-9092-80fc7b2566c2"), new Guid("5d730626-a1c0-4640-9dcb-221248425f51"), "uk", "Київ" },
                    { new Guid("b1e05eb9-480f-4ecf-a08f-96355830c04e"), new Guid("87a610fa-0314-4346-a0c5-d7185a3cc147"), "en", "Zhytomyr" },
                    { new Guid("b4189e38-af31-4d05-8f37-fe013bdde52a"), new Guid("545f18c0-e7e0-4909-b749-e68eb86bdfd5"), "uk", "Дніпро" },
                    { new Guid("b6d54ef1-9cbc-411b-9cb7-07da3cc06204"), new Guid("7666b9e7-7a74-48c2-833a-ebea6b92494e"), "en", "Rivne" },
                    { new Guid("b766ea56-3404-476a-856f-64e6b19a0558"), new Guid("4bc6769a-12d9-4f94-a14b-f92e2288e8da"), "en", "Varshava" },
                    { new Guid("bf971a85-2739-4867-9dba-c03c172556aa"), new Guid("141068d2-e188-4bf4-9d6f-64943bb343ac"), "uk", "Одеса" },
                    { new Guid("c8a676ce-0c93-4c89-949a-8031bafe67f0"), new Guid("dd5d3e25-4f7c-44b1-b6e0-edc428e984ff"), "en", "Ivano-Frankivsk" },
                    { new Guid("cb441634-c683-4bd2-a202-d49f063d1387"), new Guid("089d79e9-e533-4099-b531-4ef9c322a7e5"), "en", "Lutsk" },
                    { new Guid("d24920b2-3f0c-4abd-b7e4-f123c69deb78"), new Guid("c0d5b96c-57dd-4655-a696-a25813d3b801"), "uk", "Чернігів" },
                    { new Guid("d356a64e-d052-439b-842c-0d85774ddeed"), new Guid("883aa240-b9a7-47d7-8cf7-d9c8574c8875"), "en", "Kropyvnytskyi" },
                    { new Guid("d3ea64df-6f1b-4268-b0e5-16c212b8891c"), new Guid("d1394a08-6508-4cbd-9643-7a338ee128f9"), "uk", "Херсон" },
                    { new Guid("d4da6591-03ea-4ec2-b089-3e53000b74af"), new Guid("de8a94a9-cddb-47bd-bf1b-b17e4ef292cc"), "en", "Lviv" }
                });

            migrationBuilder.InsertData(
                table: "CityTranslations",
                columns: new[] { "Id", "CityId", "Language", "Name" },
                values: new object[,]
                {
                    { new Guid("d7467d2a-9cd0-49e0-b15e-104edf2412ea"), new Guid("ac9ea5b2-5ba5-43fb-b95d-154f9eebc4c8"), "uk", "Ужгород" },
                    { new Guid("dfcfcd60-746f-4cad-919a-7ce3dfada062"), new Guid("95fade87-f693-445e-b16d-2017c4734a0d"), "uk", "Тернопіль" },
                    { new Guid("e67392b1-3831-4b68-8209-6b22ef1d86f6"), new Guid("883aa240-b9a7-47d7-8cf7-d9c8574c8875"), "uk", "Кропивницький" },
                    { new Guid("e6be808a-36e4-4795-b28e-0203feb5c7eb"), new Guid("de8a94a9-cddb-47bd-bf1b-b17e4ef292cc"), "uk", "Львів" },
                    { new Guid("e6eb3a50-462b-4da5-8b40-e9b6b51b5da0"), new Guid("1d061e77-6378-4159-8968-3e9504c40a52"), "en", "Sumy" },
                    { new Guid("ebfe0d69-f755-493e-874b-f5505eb59b2f"), new Guid("54baa347-8b04-47a1-ab6f-fa720b9b7cd5"), "en", "Kharkiv" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("186aa52c-c83c-4aad-8cf5-d11f130d9e0d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("18a87db2-878a-412e-9d73-c943f8d0484e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("249dce4c-31a4-4ccb-a51e-c128cd665eb7"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("289137e0-a5bb-4532-b8cc-c35b4a0cf4fd"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2c60b36f-0b66-4834-9351-c8343112f666"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("2d7f990a-ed4b-4767-9bbc-303e4011ce63"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("321ba799-d34f-489b-9bd7-c9c1b9149b3f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3733a32c-a897-448b-a36b-2bd4c2bcaa87"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("45c9f3a6-f371-431b-94d0-6aa3a22c9626"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("507ae7fc-f10d-494f-a4b2-c2213bdfe53a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("55769830-704e-47f4-ab64-027413ea3115"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5b6111cf-db3e-4698-9868-df9aa33a403e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("5d96e81a-8bf7-4930-9eb0-97551085f80b"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("60886a7a-5327-4a9e-b0a0-ce7e5411de41"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6aa2fae9-ddb3-4632-8b53-236ad059a95e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6df95ec8-2826-4ef5-8e69-6b6f96061714"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("6f4a11a7-f15b-49e1-ba6c-0d79eb134b3d"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7092094a-d8a7-42e6-ac4d-f166726c1e0f"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("71e520a9-9e9a-4c01-93b0-c95b826401b5"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("729843d3-36d8-4dc2-aa38-93e00f6732cc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("73aad800-4dfc-4e9b-8eb8-8f5e194539e3"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("79c9ec0b-c3e9-4bee-9164-982b472ce6c2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("7e07c44e-1c92-43f9-9ef1-b56ad69c269e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("86cd4e81-812b-4123-83ab-229969a9eb70"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("87b3273d-5225-4ba6-8521-19d2f8d2dc2a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("92eb9371-6e8f-4d0d-8133-07bcdb702434"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("92f76a7d-4fca-459e-a37a-99b2a9fa54b9"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9726f64f-f590-42a7-8af0-a5f6f7eaf223"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("9830aa4e-3aa1-4e6b-97a6-09cce651212c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("a074273d-4c57-4d91-85bf-8a730a4853fc"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("af82da64-76d1-4135-9092-80fc7b2566c2"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b1e05eb9-480f-4ecf-a08f-96355830c04e"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b4189e38-af31-4d05-8f37-fe013bdde52a"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b6d54ef1-9cbc-411b-9cb7-07da3cc06204"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("b766ea56-3404-476a-856f-64e6b19a0558"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("bf971a85-2739-4867-9dba-c03c172556aa"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("c8a676ce-0c93-4c89-949a-8031bafe67f0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("cb441634-c683-4bd2-a202-d49f063d1387"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d24920b2-3f0c-4abd-b7e4-f123c69deb78"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d356a64e-d052-439b-842c-0d85774ddeed"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d3ea64df-6f1b-4268-b0e5-16c212b8891c"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d4da6591-03ea-4ec2-b089-3e53000b74af"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("d7467d2a-9cd0-49e0-b15e-104edf2412ea"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("dfcfcd60-746f-4cad-919a-7ce3dfada062"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e67392b1-3831-4b68-8209-6b22ef1d86f6"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e6be808a-36e4-4795-b28e-0203feb5c7eb"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("e6eb3a50-462b-4da5-8b40-e9b6b51b5da0"));

            migrationBuilder.DeleteData(
                table: "CityTranslations",
                keyColumn: "Id",
                keyValue: new Guid("ebfe0d69-f755-493e-874b-f5505eb59b2f"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("0bbb7e28-b1c1-4ae1-a387-34fefdce95e6"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("3cd6f454-e48b-4c8b-b69c-169baed79c91"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("8fd4e5a9-569d-4c6e-b346-abd647d442e2"));

            migrationBuilder.DeleteData(
                table: "CountryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("fb789f54-80a8-4476-ba73-b33b329fd882"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0e263e8e-3e11-4c06-a9a3-9d7c43a67ab2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("35ace4d2-6eba-4914-913b-ddd105de8da4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("089d79e9-e533-4099-b531-4ef9c322a7e5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("10548d21-4b1d-415d-b98b-f060d3034635"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("141068d2-e188-4bf4-9d6f-64943bb343ac"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1d061e77-6378-4159-8968-3e9504c40a52"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("42206872-36b7-4979-af0a-a166cf4740be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43b7d673-dcf2-46a3-9567-25ff782bdcb1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4bc6769a-12d9-4f94-a14b-f92e2288e8da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4c53d37e-9e9a-4719-b928-835bba74ec7c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("545f18c0-e7e0-4909-b749-e68eb86bdfd5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("54baa347-8b04-47a1-ab6f-fa720b9b7cd5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b858e4f-b097-4c77-8414-5a1b4f95bfbb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5d730626-a1c0-4640-9dcb-221248425f51"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7666b9e7-7a74-48c2-833a-ebea6b92494e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("87a610fa-0314-4346-a0c5-d7185a3cc147"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("883aa240-b9a7-47d7-8cf7-d9c8574c8875"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("95fade87-f693-445e-b16d-2017c4734a0d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a4acf92e-941e-44a7-9648-cdc90defd393"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ac9ea5b2-5ba5-43fb-b95d-154f9eebc4c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("afe68acc-334a-492e-9c6f-18c69d563867"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd8de84d-b962-4e2b-a094-e4411ee8c2c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c0d5b96c-57dd-4655-a696-a25813d3b801"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d1394a08-6508-4cbd-9643-7a338ee128f9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dd5d3e25-4f7c-44b1-b6e0-edc428e984ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("de8a94a9-cddb-47bd-bf1b-b17e4ef292cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06ade6df-2f63-420d-9949-b779c4ba4fb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58c88726-e32e-4239-92a7-3b0474fac235"));

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
    }
}

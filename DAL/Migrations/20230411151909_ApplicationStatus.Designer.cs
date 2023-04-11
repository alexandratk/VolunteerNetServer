﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(VolunteerNetServerDBContext))]
    [Migration("20230411151909_ApplicationStatus")]
    partial class ApplicationStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Entities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97d1c36c-3ddc-47a6-990c-ef550caea890"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "vi"
                        },
                        new
                        {
                            Id = new Guid("27b345af-b245-4dcf-885c-dadc12ff401f"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "dn"
                        },
                        new
                        {
                            Id = new Guid("4ea1dd83-0390-4764-9667-0de832dc8e4d"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "zhy"
                        },
                        new
                        {
                            Id = new Guid("fc381da9-06f7-4706-92ae-8239f7b230e9"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "zp"
                        },
                        new
                        {
                            Id = new Guid("5b9557e0-2735-49bc-8304-485b1c998ce9"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "if"
                        },
                        new
                        {
                            Id = new Guid("438d08eb-65d3-472b-8e04-92324ef8e7e5"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "ky"
                        },
                        new
                        {
                            Id = new Guid("1a85a081-6e9e-4755-a769-df401a1c952e"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "kr"
                        },
                        new
                        {
                            Id = new Guid("ea236f39-abb8-4bf6-a380-7f82cff3aef2"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "lut"
                        },
                        new
                        {
                            Id = new Guid("ccea688d-164f-4907-a000-33d599abcdb4"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "lv"
                        },
                        new
                        {
                            Id = new Guid("18d13fba-963a-4efb-81f5-d5c2f8aee284"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "my"
                        },
                        new
                        {
                            Id = new Guid("af0a1689-119f-4e86-8f8f-53ba34254110"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "od"
                        },
                        new
                        {
                            Id = new Guid("9ad1c7b5-700d-4c02-ab83-7501212acb40"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "pol"
                        },
                        new
                        {
                            Id = new Guid("3496b409-f96e-41a3-9f73-1c7340c3cf8f"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "ri"
                        },
                        new
                        {
                            Id = new Guid("6941d941-6d28-4c65-ad81-952ecab76061"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "su"
                        },
                        new
                        {
                            Id = new Guid("4b541556-7574-4b03-ba43-832fa1c2fc18"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "ter"
                        },
                        new
                        {
                            Id = new Guid("8a65a26a-1a80-4210-a98c-0b633d487e37"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "uzh"
                        },
                        new
                        {
                            Id = new Guid("d6c71253-5b8a-46ef-9423-792b49a033cb"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "khar"
                        },
                        new
                        {
                            Id = new Guid("8bc7bdf2-45d4-4378-9dfd-4131040b81f6"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "kher"
                        },
                        new
                        {
                            Id = new Guid("5cdcb0d6-1115-4584-ba20-31b204aa5a70"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "khm"
                        },
                        new
                        {
                            Id = new Guid("6ed3095e-0b57-491d-b589-a207d1bbd9be"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "chk"
                        },
                        new
                        {
                            Id = new Guid("66705526-19f2-4379-917b-d07e04a6e5d3"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "chv"
                        },
                        new
                        {
                            Id = new Guid("e25dbb94-ece1-4a4c-8ed1-b9430c63adc7"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "chh"
                        },
                        new
                        {
                            Id = new Guid("81fae4a1-2bc5-4e75-9a7d-dcebbc5a32a8"),
                            CountryId = new Guid("413aeb28-7be8-43cd-ab70-392b03b403c0"),
                            ISO = "var"
                        },
                        new
                        {
                            Id = new Guid("e8f505a5-e5a6-45b5-b67b-fa539be74344"),
                            CountryId = new Guid("413aeb28-7be8-43cd-ab70-392b03b403c0"),
                            ISO = "lub"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CityTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("CityTranslations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("262c7a26-8ffa-49fa-9b29-f629fffdd91b"),
                            CityId = new Guid("97d1c36c-3ddc-47a6-990c-ef550caea890"),
                            Language = "uk",
                            Name = "Вінниця"
                        },
                        new
                        {
                            Id = new Guid("f72f8c61-e1a0-4519-a5b6-f621ba3ebdec"),
                            CityId = new Guid("27b345af-b245-4dcf-885c-dadc12ff401f"),
                            Language = "uk",
                            Name = "Дніпро"
                        },
                        new
                        {
                            Id = new Guid("11cf2804-9be8-4a78-806c-4b5cff9ee201"),
                            CityId = new Guid("4ea1dd83-0390-4764-9667-0de832dc8e4d"),
                            Language = "uk",
                            Name = "Житомир"
                        },
                        new
                        {
                            Id = new Guid("4445c24c-259a-49fe-95f2-d927174477b4"),
                            CityId = new Guid("fc381da9-06f7-4706-92ae-8239f7b230e9"),
                            Language = "uk",
                            Name = "Запоріжжя"
                        },
                        new
                        {
                            Id = new Guid("ebb47916-a0dd-4ea7-9f5f-0689e2627343"),
                            CityId = new Guid("5b9557e0-2735-49bc-8304-485b1c998ce9"),
                            Language = "uk",
                            Name = "Івано-Франківськ"
                        },
                        new
                        {
                            Id = new Guid("112529a3-81ac-496c-9f28-c57dcca7b23e"),
                            CityId = new Guid("438d08eb-65d3-472b-8e04-92324ef8e7e5"),
                            Language = "uk",
                            Name = "Київ"
                        },
                        new
                        {
                            Id = new Guid("1591a6c3-630c-4887-a7e7-5301a47bf548"),
                            CityId = new Guid("1a85a081-6e9e-4755-a769-df401a1c952e"),
                            Language = "uk",
                            Name = "Кропивницький"
                        },
                        new
                        {
                            Id = new Guid("4ce21b4d-87ae-4c91-b4ee-77a5a83acaff"),
                            CityId = new Guid("ea236f39-abb8-4bf6-a380-7f82cff3aef2"),
                            Language = "uk",
                            Name = "Луцьк"
                        },
                        new
                        {
                            Id = new Guid("15d44b55-f72f-4ea3-b097-23488c276d21"),
                            CityId = new Guid("ccea688d-164f-4907-a000-33d599abcdb4"),
                            Language = "uk",
                            Name = "Львів"
                        },
                        new
                        {
                            Id = new Guid("ebb012f9-5d45-4dcb-b74d-cc7831b85ae2"),
                            CityId = new Guid("18d13fba-963a-4efb-81f5-d5c2f8aee284"),
                            Language = "uk",
                            Name = "Миколаїв"
                        },
                        new
                        {
                            Id = new Guid("47e5df6f-ea9c-4a2a-860d-c1b2d38eef38"),
                            CityId = new Guid("af0a1689-119f-4e86-8f8f-53ba34254110"),
                            Language = "uk",
                            Name = "Одеса"
                        },
                        new
                        {
                            Id = new Guid("82a03978-ce56-4c75-a46d-e8341893ea5a"),
                            CityId = new Guid("9ad1c7b5-700d-4c02-ab83-7501212acb40"),
                            Language = "uk",
                            Name = "Полтава"
                        },
                        new
                        {
                            Id = new Guid("af9f7025-3d94-4f7d-97c5-9558529b8977"),
                            CityId = new Guid("3496b409-f96e-41a3-9f73-1c7340c3cf8f"),
                            Language = "uk",
                            Name = "Рівне"
                        },
                        new
                        {
                            Id = new Guid("5584c511-f485-401f-992e-f03a8c19ea2b"),
                            CityId = new Guid("6941d941-6d28-4c65-ad81-952ecab76061"),
                            Language = "uk",
                            Name = "Суми"
                        },
                        new
                        {
                            Id = new Guid("10c4cb79-c79b-40ab-b701-6cee0ecd3b42"),
                            CityId = new Guid("4b541556-7574-4b03-ba43-832fa1c2fc18"),
                            Language = "uk",
                            Name = "Тернопіль"
                        },
                        new
                        {
                            Id = new Guid("f8d4247c-92a0-44c8-9ed2-a371d5a1b57d"),
                            CityId = new Guid("8a65a26a-1a80-4210-a98c-0b633d487e37"),
                            Language = "uk",
                            Name = "Ужгород"
                        },
                        new
                        {
                            Id = new Guid("891f26c5-cb51-4f84-b765-915cd041831d"),
                            CityId = new Guid("d6c71253-5b8a-46ef-9423-792b49a033cb"),
                            Language = "uk",
                            Name = "Харків"
                        },
                        new
                        {
                            Id = new Guid("44a25ac1-25e4-41ac-84d8-839a62e3f0f0"),
                            CityId = new Guid("8bc7bdf2-45d4-4378-9dfd-4131040b81f6"),
                            Language = "uk",
                            Name = "Херсон"
                        },
                        new
                        {
                            Id = new Guid("c6cbcaeb-a99c-4989-84e1-fc4fd65157c4"),
                            CityId = new Guid("5cdcb0d6-1115-4584-ba20-31b204aa5a70"),
                            Language = "uk",
                            Name = "Хмельницький"
                        },
                        new
                        {
                            Id = new Guid("7b406d2e-1a7d-42b9-84e4-8e8e3889ccad"),
                            CityId = new Guid("6ed3095e-0b57-491d-b589-a207d1bbd9be"),
                            Language = "uk",
                            Name = "Черкаси"
                        },
                        new
                        {
                            Id = new Guid("493a3ad7-2690-4883-90f8-87928128c93c"),
                            CityId = new Guid("66705526-19f2-4379-917b-d07e04a6e5d3"),
                            Language = "uk",
                            Name = "Чернівці"
                        },
                        new
                        {
                            Id = new Guid("4019d5c3-6a75-46b8-8833-1b0bd2b827a0"),
                            CityId = new Guid("e25dbb94-ece1-4a4c-8ed1-b9430c63adc7"),
                            Language = "uk",
                            Name = "Чернігів"
                        },
                        new
                        {
                            Id = new Guid("3cd416b3-4b0a-4d62-9f90-8c67837603d3"),
                            CityId = new Guid("97d1c36c-3ddc-47a6-990c-ef550caea890"),
                            Language = "en",
                            Name = "Vinnytsia"
                        },
                        new
                        {
                            Id = new Guid("40382850-74da-4c50-ba1c-6ec073ae04ea"),
                            CityId = new Guid("27b345af-b245-4dcf-885c-dadc12ff401f"),
                            Language = "en",
                            Name = "Dnipro"
                        },
                        new
                        {
                            Id = new Guid("bfbf383f-a36b-49d5-bdd7-dfd05d42f175"),
                            CityId = new Guid("4ea1dd83-0390-4764-9667-0de832dc8e4d"),
                            Language = "en",
                            Name = "Zhytomyr"
                        },
                        new
                        {
                            Id = new Guid("a2761b19-7aa1-4f51-aee9-a5a5b2c27f7f"),
                            CityId = new Guid("fc381da9-06f7-4706-92ae-8239f7b230e9"),
                            Language = "en",
                            Name = "Zaporizhzhia"
                        },
                        new
                        {
                            Id = new Guid("7b1c5e1f-666f-40b3-b903-9d8e6b01c1a7"),
                            CityId = new Guid("5b9557e0-2735-49bc-8304-485b1c998ce9"),
                            Language = "en",
                            Name = "Ivano-Frankivsk"
                        },
                        new
                        {
                            Id = new Guid("dbecbf98-68e1-4f92-9822-c7b0c4009b6d"),
                            CityId = new Guid("438d08eb-65d3-472b-8e04-92324ef8e7e5"),
                            Language = "en",
                            Name = "Kyiv"
                        },
                        new
                        {
                            Id = new Guid("9f99e88c-f40e-4328-a6d5-13a995f5dba1"),
                            CityId = new Guid("1a85a081-6e9e-4755-a769-df401a1c952e"),
                            Language = "en",
                            Name = "Kropyvnytskyi"
                        },
                        new
                        {
                            Id = new Guid("87a10e36-945a-4911-a840-83ff03bb25d6"),
                            CityId = new Guid("ea236f39-abb8-4bf6-a380-7f82cff3aef2"),
                            Language = "en",
                            Name = "Lutsk"
                        },
                        new
                        {
                            Id = new Guid("d8ff6e2d-ffad-4142-b5e9-a4136ade0b3d"),
                            CityId = new Guid("ccea688d-164f-4907-a000-33d599abcdb4"),
                            Language = "en",
                            Name = "Lviv"
                        },
                        new
                        {
                            Id = new Guid("67a50ada-f7ee-4bb9-8142-3d6160ab998e"),
                            CityId = new Guid("18d13fba-963a-4efb-81f5-d5c2f8aee284"),
                            Language = "en",
                            Name = "Mykolaiv"
                        },
                        new
                        {
                            Id = new Guid("2476e215-acea-4d71-803c-7c24f1402876"),
                            CityId = new Guid("af0a1689-119f-4e86-8f8f-53ba34254110"),
                            Language = "en",
                            Name = "Odesa"
                        },
                        new
                        {
                            Id = new Guid("a427ef8a-e5ac-4d22-9592-580a0b8d8d57"),
                            CityId = new Guid("9ad1c7b5-700d-4c02-ab83-7501212acb40"),
                            Language = "en",
                            Name = "Poltava"
                        },
                        new
                        {
                            Id = new Guid("38301f81-90fe-4c42-9ac5-6459c19b4e32"),
                            CityId = new Guid("3496b409-f96e-41a3-9f73-1c7340c3cf8f"),
                            Language = "en",
                            Name = "Rivne"
                        },
                        new
                        {
                            Id = new Guid("9b4a1692-5750-4fb7-ba6d-4f5209a38b82"),
                            CityId = new Guid("6941d941-6d28-4c65-ad81-952ecab76061"),
                            Language = "en",
                            Name = "Sumy"
                        },
                        new
                        {
                            Id = new Guid("d060994b-8bd9-45a0-a028-3b8093d2453f"),
                            CityId = new Guid("4b541556-7574-4b03-ba43-832fa1c2fc18"),
                            Language = "en",
                            Name = "Ternopil"
                        },
                        new
                        {
                            Id = new Guid("cead984c-749e-4df2-8fd3-f1c566a78621"),
                            CityId = new Guid("8a65a26a-1a80-4210-a98c-0b633d487e37"),
                            Language = "en",
                            Name = "Uzhhorod"
                        },
                        new
                        {
                            Id = new Guid("202fb73f-607d-437a-82d9-bb0069eb7e6c"),
                            CityId = new Guid("d6c71253-5b8a-46ef-9423-792b49a033cb"),
                            Language = "en",
                            Name = "Kharkiv"
                        },
                        new
                        {
                            Id = new Guid("77235c1d-8710-44e0-bcfd-ec944fcee8c6"),
                            CityId = new Guid("8bc7bdf2-45d4-4378-9dfd-4131040b81f6"),
                            Language = "en",
                            Name = "Kherson"
                        },
                        new
                        {
                            Id = new Guid("924c103d-ef28-4e8c-bde2-5fd880489ce8"),
                            CityId = new Guid("5cdcb0d6-1115-4584-ba20-31b204aa5a70"),
                            Language = "en",
                            Name = "Khmelnytskyi"
                        },
                        new
                        {
                            Id = new Guid("4fb1a3d6-f531-4513-8d81-49039e267f70"),
                            CityId = new Guid("6ed3095e-0b57-491d-b589-a207d1bbd9be"),
                            Language = "en",
                            Name = "Cherkasy"
                        },
                        new
                        {
                            Id = new Guid("513da0ea-6ef8-478b-afca-69f99f825baf"),
                            CityId = new Guid("66705526-19f2-4379-917b-d07e04a6e5d3"),
                            Language = "en",
                            Name = "Chernivtsi"
                        },
                        new
                        {
                            Id = new Guid("14b05bad-b90a-432f-aac5-491bde6c60de"),
                            CityId = new Guid("e25dbb94-ece1-4a4c-8ed1-b9430c63adc7"),
                            Language = "en",
                            Name = "Chernihiv"
                        },
                        new
                        {
                            Id = new Guid("46346f0a-a7fd-43fa-840f-73727e8bdf63"),
                            CityId = new Guid("81fae4a1-2bc5-4e75-9a7d-dcebbc5a32a8"),
                            Language = "uk",
                            Name = "Варшава"
                        },
                        new
                        {
                            Id = new Guid("d1bfee7b-3dde-4de1-bdfb-10ec368c52dd"),
                            CityId = new Guid("e8f505a5-e5a6-45b5-b67b-fa539be74344"),
                            Language = "uk",
                            Name = "Люблін"
                        },
                        new
                        {
                            Id = new Guid("67861c6d-69cb-48aa-aba6-86b1e075f345"),
                            CityId = new Guid("81fae4a1-2bc5-4e75-9a7d-dcebbc5a32a8"),
                            Language = "en",
                            Name = "Varshava"
                        },
                        new
                        {
                            Id = new Guid("af734eea-31e6-43c3-831a-95f56223758f"),
                            CityId = new Guid("e8f505a5-e5a6-45b5-b67b-fa539be74344"),
                            Language = "en",
                            Name = "Lublin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            ISO = "uk"
                        },
                        new
                        {
                            Id = new Guid("413aeb28-7be8-43cd-ab70-392b03b403c0"),
                            ISO = "pl"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CountryTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryTranslations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2cd351fc-e723-49db-9f07-59824d1fa110"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            Language = "en",
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = new Guid("c0d513cb-28b7-463b-88f6-0dcfd55b1796"),
                            CountryId = new Guid("7c938a35-a10f-4a0b-b084-a7112d7f88a5"),
                            Language = "uk",
                            Name = "Україна"
                        },
                        new
                        {
                            Id = new Guid("0f01491a-d44c-43f9-9c45-d69a9ddd8faf"),
                            CountryId = new Guid("413aeb28-7be8-43cd-ab70-392b03b403c0"),
                            Language = "en",
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("60fa9178-3000-4255-9c4a-4bef2457f710"),
                            CountryId = new Guid("413aeb28-7be8-43cd-ab70-392b03b403c0"),
                            Language = "uk",
                            Name = "Польша"
                        });
                });

            modelBuilder.Entity("DAL.Entities.ProfilePicture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ProfilePictures");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4ee308a-0d4e-45f9-a058-35bbada00c92"),
                            Title = "medicine"
                        },
                        new
                        {
                            Id = new Guid("6c9816a8-3721-4919-9dee-c7e338e2c5c1"),
                            Title = "cook"
                        });
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e251e4e6-4ae0-4dcb-9c7e-b19b91519c39"),
                            CityId = new Guid("97d1c36c-3ddc-47a6-990c-ef550caea890"),
                            DateOfBirth = new DateTime(2023, 4, 11, 18, 19, 9, 649, DateTimeKind.Local).AddTicks(9131),
                            FirstName = "the first",
                            LastName = "admin",
                            Login = "ourfirstadmin",
                            Password = "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=",
                            Phone = "+11111111111",
                            Role = "admin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentFormat")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NULL");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("DAL.Entities.Application", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.HasOne("DAL.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DAL.Entities.CityTranslation", b =>
                {
                    b.HasOne("DAL.Entities.City", "City")
                        .WithMany("CityTranslations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DAL.Entities.CountryTranslation", b =>
                {
                    b.HasOne("DAL.Entities.Country", "Country")
                        .WithMany("CountryTranslations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DAL.Entities.ProfilePicture", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithOne("ProfilePicture")
                        .HasForeignKey("DAL.Entities.ProfilePicture", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.HasOne("DAL.Entities.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.HasOne("DAL.Entities.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.Navigation("CityTranslations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("CountryTranslations");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Navigation("UserSkills");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("ProfilePicture");

                    b.Navigation("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
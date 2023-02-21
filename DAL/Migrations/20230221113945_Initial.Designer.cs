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
    [Migration("20230221113945_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = new Guid("c216da41-067d-42e6-9803-28edd811717c"),
                            CountryId = new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"),
                            ISO = "zp"
                        },
                        new
                        {
                            Id = new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"),
                            CountryId = new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"),
                            ISO = "ha"
                        },
                        new
                        {
                            Id = new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"),
                            CountryId = new Guid("2cf303e5-131a-4786-a715-e47d585c8103"),
                            ISO = "var"
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
                            Id = new Guid("771155b1-372a-4390-950e-22d91bbb53ac"),
                            CityId = new Guid("c216da41-067d-42e6-9803-28edd811717c"),
                            Language = "en",
                            Name = "Zap"
                        },
                        new
                        {
                            Id = new Guid("7bd3a1bb-35ae-49b0-8704-1a089ecd959d"),
                            CityId = new Guid("c216da41-067d-42e6-9803-28edd811717c"),
                            Language = "uk",
                            Name = "Зап"
                        },
                        new
                        {
                            Id = new Guid("fadef7b5-6c84-4969-bd1e-decc439735fd"),
                            CityId = new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"),
                            Language = "en",
                            Name = "Khar"
                        },
                        new
                        {
                            Id = new Guid("0ad5ac42-01e7-4362-9da9-311fc60afcbd"),
                            CityId = new Guid("a80c1454-40c1-44ae-ad02-dcbca145321b"),
                            Language = "uk",
                            Name = "Харків"
                        },
                        new
                        {
                            Id = new Guid("f63c3e90-9d55-4970-9e3a-1648951e32c5"),
                            CityId = new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"),
                            Language = "en",
                            Name = "Varshava"
                        },
                        new
                        {
                            Id = new Guid("07760e6a-3596-4d91-af1c-f000b48e8943"),
                            CityId = new Guid("5ca86c7b-1ba1-429d-a914-076bd3e26c79"),
                            Language = "uk",
                            Name = "Варшава"
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
                            Id = new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"),
                            ISO = "uk"
                        },
                        new
                        {
                            Id = new Guid("2cf303e5-131a-4786-a715-e47d585c8103"),
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
                            Id = new Guid("36344907-59b1-4149-9d24-25967cc41341"),
                            CountryId = new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"),
                            Language = "en",
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = new Guid("43662264-fb01-42c5-91d7-73439d877323"),
                            CountryId = new Guid("e958eff1-d62f-4440-a6cd-7a411980dc00"),
                            Language = "uk",
                            Name = "Україна"
                        },
                        new
                        {
                            Id = new Guid("d7c6d5ea-4319-46ed-ad46-02e4825c71a3"),
                            CountryId = new Guid("2cf303e5-131a-4786-a715-e47d585c8103"),
                            Language = "en",
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("d2f3d0eb-33a7-47ed-a551-bb4abad42393"),
                            CountryId = new Guid("2cf303e5-131a-4786-a715-e47d585c8103"),
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
                            Id = new Guid("691058e6-ed12-4815-b1a2-2052c36b11c8"),
                            Title = "medicine"
                        },
                        new
                        {
                            Id = new Guid("d713f8bb-3be7-49e3-a51c-db8077127049"),
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

                    b.HasKey("UserId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("UserSkill");
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
                    b.Navigation("ProfilePicture");

                    b.Navigation("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}

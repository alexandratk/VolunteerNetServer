using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace DAL.Data
{
    public class VolunteerNetServerDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<CityTranslation> CityTranslations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslation> CountryTranslations { get; set; }
        public DbSet<ProfilePicture> ProfilePictures { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }

        public VolunteerNetServerDBContext(DbContextOptions<VolunteerNetServerDBContext> options) : base (options)
        {
            Database.Migrate();
        }

        //public PhotoAlbumDbContext(DbContextOptions<PhotoAlbumDbContext> options) : base(options)
        //{

        //}

        public VolunteerNetServerDBContext()
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost;Database=VolunteerNet;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(p => p.Skills)
                .WithMany(p => p.Users)
                .UsingEntity<UserSkill>(
                    j => j
                        .HasOne(pt => pt.Skill)
                        .WithMany(t => t.UserSkills)
                        .HasForeignKey(pt => pt.SkillId),
                    j => j
                        .HasOne(pt => pt.User)
                        .WithMany(p => p.UserSkills)
                        .HasForeignKey(pt => pt.UserId),
                    j =>
                    {
                        j.Property(pt => pt.DocumentFormat).HasDefaultValueSql("NULL");
                        j.HasKey(t => new { t.UserId, t.SkillId });
                    });

            modelBuilder.Entity<Skill>().HasData(
                new Skill[]
                {
                    new Skill() { Id = Guid.NewGuid(), Title = "medicine" },
                    new Skill() { Id = Guid.NewGuid(), Title = "cook" }
                });

            Guid Id1 = Guid.NewGuid();
            Guid Id2 = Guid.NewGuid();

            modelBuilder.Entity<Country>().HasData(
                new Country[] 
                { 
                    new Country() { Id = Id1, ISO = "uk" },
                    new Country() { Id = Id2, ISO = "pl" }
                });

            Guid CId1 = Guid.NewGuid();
            Guid CId2 = Guid.NewGuid();
            Guid CId3 = Guid.NewGuid();

            modelBuilder.Entity<City>().HasData(
                new City[]
                {
                    new City { Id = CId1, CountryId = Id1, ISO = "zp" },
                    new City { Id = CId2, CountryId = Id1, ISO = "ha" },
                    new City { Id = CId3, CountryId = Id2, ISO = "var" }
                });

            modelBuilder.Entity<CountryTranslation>().HasData(
                new CountryTranslation[]
                {
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "en", CountryId = Id1, Name = "Ukraine" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "uk", CountryId = Id1, Name = "Україна" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "en", CountryId = Id2, Name = "Poland" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "uk", CountryId = Id2, Name = "Польша" },
                });

            modelBuilder.Entity<CityTranslation>().HasData(
                new CityTranslation[]
                {
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = CId1, Name = "Zap"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = CId1, Name = "Зап"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = CId2, Name = "Khar"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = CId2, Name = "Харків"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = CId3, Name = "Varshava"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = CId3, Name = "Варшава"}
                });
        }
    }
}

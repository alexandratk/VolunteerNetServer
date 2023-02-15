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
        }
    }
}

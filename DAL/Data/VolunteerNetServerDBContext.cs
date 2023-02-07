using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace DAL.Data
{
    public class VolunteerNetServerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProfilePicture> ProfilePictures { get; set; }

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
        //    optionsBuilder.UseSqlServer(@"Server=host.docker.internal;Database=VolunteerNet;User Id=SA;Password=2Secure*Password2;");
        //}
    }
}

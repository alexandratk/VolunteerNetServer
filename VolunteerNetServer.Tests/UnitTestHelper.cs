using AutoMapper;
using BLL.Helpers;
using Castle.Core.Resource;
using DAL.Data;
using DAL.DefaultData;
using DAL.Entities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunteerNetServer.Tests
{
    internal class UnitTestHelper
    {
        public static DbContextOptions<VolunteerNetServerDBContext> GetUnitTestDbOptions()
        {
            var options = new DbContextOptionsBuilder<VolunteerNetServerDBContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var context = new VolunteerNetServerDBContext(options))
            {
                SeedData(context);
            }

            return options;
        }

        public static IMapper CreateMapperProfile()
        {
            var myProfile = new AutomapperProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));

            return new Mapper(configuration);
        }

        public static void SeedData(VolunteerNetServerDBContext context)
        {
            User user = new User();
            user.Id = Guid.Parse("e3b39f47-752d-4b00-8e08-02ea01e4970b");
            user.Login = "our1admin@gmail.com";
            user.Password = ComputeSha256Hash("our1admin@gmail.com");
            user.FirstName = "the first";
            user.LastName = "admin";
            user.DateOfBirth = DateTime.Now;
            user.Phone = "+11111111111";
            user.Role = "admin";
            user.CityId = Guid.Parse("81460232-f4c3-46b2-a4fc-1182217b7c39");
            context.Add(user);
            context.SaveChanges();
        }

        private static string ComputeSha256Hash(string rawData)
        {
            byte[] salt = Convert.FromBase64String("8XGkVrbRORntMVvDROdQGA==");

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: rawData,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}

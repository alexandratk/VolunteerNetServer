using DAL.Entities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class FirstAdmin
    {
        public User User { get; set; }

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

        public FirstAdmin()
        {
            User = new User();
            User.Id = Guid.NewGuid();
            User.Login = "our1admin@gmail.com";
            User.Password = ComputeSha256Hash("our1admin@gmail.com");
            User.FirstName = "the first";
            User.LastName = "admin";
            User.DateOfBirth = DateTime.Now;
            User.Phone = "+11111111111";
            User.Role = "admin";
        }
    }
}

using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;


namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task RegisterAsync(UserModel model)
        {
            model.Id = Guid.NewGuid();
            model.Password = HashHelper.ComputeSha256Hash(model.Password);
            
            var mapperUser = mapper.Map<UserModel, User>(model);

            var memoryStream = new MemoryStream();
            model.Image.CopyTo(memoryStream);
            mapperUser.Image = memoryStream.ToArray();
            mapperUser.ImageFormat = model.Image.ContentType;

            await unitOfWork.UserRepository.AddAsync(mapperUser);
        }

        public async Task<AuthResponseModel> AuthUser(AuthRequestModel authRequestModel)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByLoginAndPass(
                authRequestModel.Login, HashHelper.ComputeSha256Hash(authRequestModel.Password));
            if (unmapperUser == null)
            {
                return new AuthResponseModel();
            }
            var mapperUser = mapper.Map<User, UserModel>(unmapperUser);

            var user = unitOfWork.UserRepository.GetByLoginAndPass(authRequestModel.Login, HashHelper.ComputeSha256Hash(authRequestModel.Password));
            //if (user == null)
            //    throw new Exception("User not found");
            //Console.WriteLine("2222");
            var token = generateJWTToken(mapperUser);
            return new AuthResponseModel()
            {
                Role = mapperUser.Role,
                jwtToken = token
            };
        }


        string generateJWTToken(UserModel person)
        {

            var now = DateTime.UtcNow;

            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            var jwt = new JwtSecurityToken(
                 issuer: AuthOptions.ISSUER,
                 audience: AuthOptions.AUDIENCE,
                 notBefore: now,
                 claims: claimsIdentity.Claims,
                 expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                 signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodedJwt;
        }

    }
}

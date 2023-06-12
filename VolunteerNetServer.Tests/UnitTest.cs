using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using WebAPI.Controllers;


namespace VolunteerNetServer.Tests
{
    [TestClass]
    public class UnitTest
    {
        [Test]
        public async Task UserService_GetUserById()
        {
            //arrange
            var expected = TestGetUserResult;
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork
                .Setup( x => x.UserRepository
                .GetByIdAsync(Guid.Parse("e3b39f47-752d-4b00-8e08-02ea01e4970b")))
                .ReturnsAsync(TestGetUser);
            var userService = new UserService(
                mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await userService
                .GetByIdAsync(Guid.Parse("e3b39f47-752d-4b00-8e08-02ea01e4970b"));

            //assert
            NUnit.Framework.Assert.That(actual, Is.EqualTo(expected));
        }

        #region TestData
        public User TestGetUser =>
            new User()
            {
                Id = Guid.Parse("e3b39f47-752d-4b00-8e08-02ea01e4970b"),
                Login = "our1admin@gmail.com",
                Password = "9qnurdZnxkigjcD0t+maG+TtODQacZLWeeeeylwyRFY=",
                FirstName = "the first",
                LastName = "admin",
                DateOfBirth = DateTime.Now,
                Phone = "+11111111111",
                Role = "admin"
            };
        public UserViewModel TestGetUserResult=> 
            new UserViewModel()
        {
                Id = Guid.Parse("e3b39f47-752d-4b00-8e08-02ea01e4970b"),
                Login = "our1admin@gmail.com",
                Password = "9qnurdZnxkigjcD0t+maG+TtODQacZLWeeeeylwyRFY=",
                FirstName = "the first",
                LastName = "admin",
                DateOfBirth = DateTime.Now,
                Phone = "+11111111111",
                Role = "admin",
                ProfilePicture = null,
                ProfilePictureFormat = null,
                NumberOfCompletedApplications = 0

        };
        #endregion
    }
}
using Moq;
using OnlineDiscussionForum.BusinessLayer.Interfaces;
using OnlineDiscussionForum.BusinessLayer.Services;
using OnlineDiscussionForum.BusinessLayer.Services.Repository;
using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineDiscussionForum.Test.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IDiscussionForumServices _forumServices;
        public readonly Mock<IDiscussionForumRepository> service = new Mock<IDiscussionForumRepository>();
        private readonly ApplicationUser _applicationUser;
        private readonly ForumThread _forumThread;
        public ExceptionalTest()
        {
            //Creating New mock Object with value.
            _forumServices = new DiscussionForumServices(service.Object);
            _applicationUser = new ApplicationUser
            {
                UserId = 1,
                Name = "Kumar Uma",
                UserTypes = UserType.Student,
                Email = "services@iiht.co.in",
                Password = "12345",
                ConfirmPassword = "12345",
                PhoneNumber = 9631475475,
                Address = "Banglore",
                IsApproved = false
            };
            _forumThread = new ForumThread
            {
                ThreadId = 1,
                ThreadName = "Science Question Discussion",
                UserTypes = UserType.Student,
                Email = "services@iiht.co.in",
                Description = "Answer this question",

            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for verify invalid User registration, if provide null object must be return null, means not possible to register
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_UserRegister()
        {
            //Arrange
            bool res = false;
            var user = new ApplicationUser
            {
                UserId = 1,
                Name = "Kumar Uma",
                UserTypes = UserType.Student,
                Email = "services@iiht.co.in",
                Password = "12345",
                ConfirmPassword = "12345",
                PhoneNumber = 9631475475,
                Address = "Banglore",
                IsApproved = false
            };
            user = null;
            //Act
            service.Setup(repo => repo.RegisterNewUser(user)).ReturnsAsync(user = null);
            var result = await _forumServices.RegisterNewUser(user);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_UserRegister=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for verify invalid Forum Thread, if provide null object must be return null, means not possible to register
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_ForumThread()
        {
            //Arrange
            bool res = false;
            var forumThread = new ForumThread
            {
                ThreadId = 1,
                ThreadName = "Science Question Discussion",
                UserTypes = UserType.Student,
                Email = "services@iiht.co.in",
                Description = "Answer this question",

            };
            forumThread = null;
            //Act
            service.Setup(repo => repo.NewForumThread(forumThread)).ReturnsAsync(forumThread = null);
            var result = await _forumServices.NewForumThread(forumThread);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_ForumThread=" + res + "\n");
            return res;
        }
    }
}

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
    public class BoundaryTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IDiscussionForumServices _forumServices;
        public readonly Mock<IDiscussionForumRepository> service = new Mock<IDiscussionForumRepository>();
        private readonly ApplicationUser _applicationUser;
        private readonly ForumThread _forumThread;
        public BoundaryTest()
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
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to validate Application User Id is return valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ApplicationUser_Id()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.RegisterNewUser(_applicationUser)).ReturnsAsync(_applicationUser);
            var result = await _forumServices.RegisterNewUser(_applicationUser);
            if (result.UserId == _applicationUser.UserId)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_ApplicationUser_Id=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to validate Forum Thread Id is return valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ForumThread_Id()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.NewForumThread(_forumThread)).ReturnsAsync(_forumThread);
            var result = await _forumServices.NewForumThread(_forumThread);
            if (result.ThreadId == _forumThread.ThreadId)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_ForumThread_Id=" + res + "\n");
            return res;
        }
    }
}

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
    public class FunctionalTests
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IDiscussionForumServices _forumServices;
        public readonly Mock<IDiscussionForumRepository> service = new Mock<IDiscussionForumRepository>();
        private readonly ApplicationUser _applicationUser;
        private readonly ForumThread _forumThread;
        public FunctionalTests()
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
        static FunctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Using this test case method try to get all Forum Thread
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllForumThread()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAllForumThread());
            var result = await _forumServices.GetAllForumThread();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_GetAllForumThread=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Forum Thread by Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ForumThreadById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.ForumThreadById(_forumThread.ThreadId)).ReturnsAsync(_forumThread);
            var result = await _forumServices.ForumThreadById(_forumThread.ThreadId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_ForumThreadById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Add a Forum Thread return async return _foruThread object of working fine.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Take_AddNewForumThread()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.NewForumThread(_forumThread)).ReturnsAsync(_forumThread);
            var result = await _forumServices.NewForumThread(_forumThread);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Take_AddNewForumThread=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Forum Thread by Name, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_FindForumThreadByName()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.FindForumThread(_forumThread.ThreadName));
            var result = await _forumServices.FindForumThread(_forumThread.ThreadName);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_FindForumThreadByName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Forum Thread by Email, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_FindForumThreadByUser_Email()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.FindForumThreadByEmail(_applicationUser.Email));
            var result = await _forumServices.FindForumThreadByEmail(_applicationUser.Email);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_FindForumThreadByUser_Email=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Add new User return async return _applicationUser object of working fine.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Take_AddNewUser()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.RegisterNewUser(_applicationUser)).ReturnsAsync(_applicationUser);
            var result = await _forumServices.RegisterNewUser(_applicationUser);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Take_AddNewUser=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Forum User by Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ForumThread_UserById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.UserById(_applicationUser.UserId)).ReturnsAsync(_applicationUser);
            var result = await _forumServices.UserById(_applicationUser.UserId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_ForumThread_UserById=" + res + "\n");
            return res;
        }
    }
}

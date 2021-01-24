using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineDiscussionForum.BusinessLayer.Interfaces;
using OnlineDiscussionForum.BusinessLayer.ViewModels;
using OnlineDiscussionForum.Entities;
using OnlineDiscussionForum.Models;

namespace OnlineDiscussionForum.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Creating Referance variable of IDiscussionForumServices and injecting in constructor
        /// </summary>
        private readonly IDiscussionForumServices _forumServices;
        public HomeController(IDiscussionForumServices discussionForumServices)
        {
            _forumServices = discussionForumServices;
        }
        /// <summary>
        /// Get all Forum Thread and user can also find thread by name and email.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string search, int page = 1)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Thread Details by Thread Id
        /// </summary>
        /// <param name="threadId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int threadId)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new Thread in InMemory Db get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewPostThread()
        {
            return View();
        }
        /// <summary>
        /// Add new Thread in InMemory Db Post Method
        /// </summary>
        /// <param name="forumThread"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> NewPostThread(ForumThread forumThread)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new User in InMemory Db get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RegisterNewUser()
        {
            return View();
        }
        /// <summary>
        /// Register new User in InMemory Db HttpPost method
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterNewUser(ApplicationUser user)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get User Details after user get registered.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> UserDetails(int userId)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add Case Study Policy
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Error Method
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

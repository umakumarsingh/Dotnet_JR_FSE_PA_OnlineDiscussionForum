using OnlineDiscussionForum.BusinessLayer.Interfaces;
using OnlineDiscussionForum.BusinessLayer.Services.Repository;
using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiscussionForum.BusinessLayer.Services
{
    public class DiscussionForumServices : IDiscussionForumServices
    {
        /// <summary>
        /// Creating Referance variable of IDiscussionForumRepository and injecting on Constructor
        /// </summary>
        private readonly IDiscussionForumRepository _forumRepository;
        public DiscussionForumServices(IDiscussionForumRepository discussionForumRepository)
        {
            _forumRepository = discussionForumRepository;
        }
        /// <summary>
        /// Find forum thread by thread name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> FindForumThread(string Name)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find thread  by User Email
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> FindForumThreadByEmail(string Email)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Forum Thread by thread Id
        /// </summary>
        /// <param name="ThreadId"></param>
        /// <returns></returns>
        public Task<ForumThread> ForumThreadById(int ThreadId)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all forum Thread
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> GetAllForumThread()
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new forum thread
        /// </summary>
        /// <param name="forumThread"></param>
        /// <returns></returns>
        public async Task<ForumThread> NewForumThread(ForumThread forumThread)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new user to forum
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> RegisterNewUser(ApplicationUser user)
        {
            //Do code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get user details after user is added.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UserById(int userId)
        {
            //Do code Here
            throw new NotImplementedException();
        }
    }
}

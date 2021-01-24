using Microsoft.EntityFrameworkCore;
using OnlineDiscussionForum.DataLayer;
using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiscussionForum.BusinessLayer.Services.Repository
{
    public class DiscussionForumRepository : IDiscussionForumRepository
    {
        /// <summary>
        /// Creating Referance variable of DiscussionForumDbContext and injecting in DiscussionForumRepository Constructor
        /// </summary>
        private readonly DiscussionForumDbContext _forumDbContext;
        public DiscussionForumRepository(DiscussionForumDbContext discussionForumDbContext)
        {
            _forumDbContext = discussionForumDbContext;
        }
        /// <summary>
        /// Find a forum thread by name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> FindForumThread(string Name)
        {
            var result = await _forumDbContext.Threads.
                Where(x => x.ThreadName == Name || x.Email == Name).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// Find a forum thread by User Email
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> FindForumThreadByEmail(string Email)
        {
            var result = await _forumDbContext.Threads.
                Where(x => x.Email == Email).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// Get forum thread by Id
        /// </summary>
        /// <param name="ThreadId"></param>
        /// <returns></returns>
        public async Task<ForumThread> ForumThreadById(int ThreadId)
        {
            var post = await _forumDbContext.Threads
                .Where(x => x.ThreadId == ThreadId).FirstOrDefaultAsync();
            return post;
        }
        /// <summary>
        /// Get all forum thread
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ForumThread>> GetAllForumThread()
        {
            var post = await _forumDbContext.Threads.
            OrderByDescending(x => x.ThreadName).ToListAsync();
            return post;
        }
        /// <summary>
        /// Add new Forum Thread
        /// </summary>
        /// <param name="forumThread"></param>
        /// <returns></returns>
        public async Task<ForumThread> NewForumThread(ForumThread forumThread)
        {
            _forumDbContext.Threads.Add(forumThread);
            await _forumDbContext.SaveChangesAsync();
            return forumThread;
        }
        /// <summary>
        /// Add new application user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> RegisterNewUser(ApplicationUser user)
        {
            _forumDbContext.Users.Add(user);
            await _forumDbContext.SaveChangesAsync();
            return user;
        }
        /// <summary>
        /// Get user by UserId after user is registred
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UserById(int userId)
        {
            var post = await _forumDbContext.Users
                .Where(x => x.UserId == userId).FirstOrDefaultAsync();
            return post;
        }
    }
}

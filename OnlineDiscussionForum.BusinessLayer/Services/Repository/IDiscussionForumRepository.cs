﻿using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiscussionForum.BusinessLayer.Services.Repository
{
    public interface IDiscussionForumRepository
    {
        Task<IEnumerable<ForumThread>> GetAllForumThread();
        Task<ForumThread> ForumThreadById( int ThreadId);
        Task<ForumThread> NewForumThread(ForumThread forumThread);
        Task<IEnumerable<ForumThread>> FindForumThread(string Name);
        Task<IEnumerable<ForumThread>> FindForumThreadByEmail(string Eamil);
        Task<ApplicationUser> RegisterNewUser(ApplicationUser user);
        Task<ApplicationUser> UserById(int userId);
    }
}

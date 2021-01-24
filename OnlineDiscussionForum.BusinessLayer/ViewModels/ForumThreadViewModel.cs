using OnlineDiscussionForum.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineDiscussionForum.BusinessLayer.ViewModels
{
    public class ForumThreadViewModel
    {
        [Required]
        public string ThreadName { get; set; }
        [Required]
        [Display(Name = "User Type")]
        public UserType? UserTypes { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public IEnumerable<ForumThread> ForumThreads { get; set; }
        public int ThreadtPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(ForumThreads.Count() / (double)ThreadtPerPage));
        }
        public IEnumerable<ForumThread> PaginatedThread()
        {
            int start = (CurrentPage - 1) * ThreadtPerPage;
            return ForumThreads.OrderBy(b => b.ThreadId).Skip(start).Take(ThreadtPerPage);
        }
    }
}

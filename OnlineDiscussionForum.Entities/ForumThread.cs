using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineDiscussionForum.Entities
{
    public class ForumThread
    {
        [Key]
        public int ThreadId { get; set; }
        [Required]
        public string ThreadName { get; set; }
        [Required]
        [Display(Name = "User Type")]
        public UserType? UserTypes { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}

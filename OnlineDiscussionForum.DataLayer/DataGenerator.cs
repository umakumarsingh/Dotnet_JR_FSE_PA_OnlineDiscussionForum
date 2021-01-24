using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OnlineDiscussionForum.DataLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DiscussionForumDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<DiscussionForumDbContext>>()))
            {
                if (context.Threads.Any())
                {
                    return;   // Data was already seeded
                }
                //context.Threads.AddRange(
                //new ForumThread
                //{
                //    ThreadId = 1,
                //    ThreadName = "Science Question Discussion",
                //    Description = "Answer this question",
                //    UserTypes = UserType.Student
                //});
                //context.SaveChanges();
            }
        }
    }
}

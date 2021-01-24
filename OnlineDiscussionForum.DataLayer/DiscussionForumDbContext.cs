using Microsoft.EntityFrameworkCore;
using OnlineDiscussionForum.Entities;
using System;

namespace OnlineDiscussionForum.DataLayer
{
    public class DiscussionForumDbContext : DbContext
    {
        public DiscussionForumDbContext(DbContextOptions<DiscussionForumDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ForumThread> Threads { get; set; }
        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasKey(x => x.UserId);
            modelBuilder.Entity<ForumThread>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using BloggingPlatform.Domain.Entities;

namespace BloggingPlatform.Infrastructure.Data
{
    public class BloggingContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity mappings here
        }
    }
}
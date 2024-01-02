using HappyHomeAspAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyHomeAspAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("article");
            modelBuilder.Entity<ArticleCategory>().ToTable("article_category");
    }
    }
}

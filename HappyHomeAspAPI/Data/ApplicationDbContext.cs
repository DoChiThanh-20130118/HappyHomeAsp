﻿using HappyHomeAspAPI.Models;
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
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ImgArticle> ImgArticles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("article");
            modelBuilder.Entity<ArticleCategory>().ToTable("article_category");
            modelBuilder.Entity<ProductType>().ToTable("product_type");
            modelBuilder.Entity<ImgArticle>().ToTable("img_article");
        }
    }
}

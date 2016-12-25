﻿namespace _1351300360陈前标
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogArticle> BlogArticles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

 
    }

    public class BlogArticle
    {
        //id
        public int Id { get; set; }
        /// 博客
        public string Title { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

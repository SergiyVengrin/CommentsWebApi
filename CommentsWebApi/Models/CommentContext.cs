using System;
using Microsoft.EntityFrameworkCore;


namespace CommentsWebApi.Models
{
    public class CommentContext : DbContext
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=CommentsDb;Username=postgres;Password=1234567890";

        public DbSet<Comment> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, ArticleId = 1, UserName = "Sergiy", Text = "Test Text", DateTime = new DateTime(2022, 2, 10, 18, 30, 15) },
                new Comment { Id = 2, ArticleId = 1, UserName = "Alex", Text = "Alex's comment", DateTime = new DateTime(2022, 3, 10, 15, 14, 13) },
                new Comment { Id = 3, ArticleId = 2, UserName = "Bob", Text = "I like it", DateTime = new DateTime(2022, 5, 1, 1, 2, 3) });
        }
        
    }
}

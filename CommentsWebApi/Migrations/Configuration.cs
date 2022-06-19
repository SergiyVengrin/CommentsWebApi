namespace CommentsWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using CommentsWebApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CommentsWebApi.Models.CommentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CommentsWebApi.Models.CommentContext";
        }

        protected override void Seed(CommentsWebApi.Models.CommentContext context)
        {
            context.Comments.AddOrUpdate(x => x.Id,
                new Comment { Id = 1, ArticleId = 1, UserName = "Sergiy", Text = "Test Text", DateTime = new DateTime(2022, 2, 10, 18, 30, 15) },
                new Comment { Id = 2, ArticleId = 1, UserName = "Alex", Text = "Alex's comment", DateTime = new DateTime(2022, 3, 10, 15, 14, 13) },
                new Comment { Id = 3, ArticleId = 2, UserName = "Bob", Text = "I like it", DateTime = new DateTime(2022, 5, 1, 1, 2, 3) });
        }
    }
}

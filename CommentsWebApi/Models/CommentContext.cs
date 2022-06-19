using System.Data.Entity;

namespace CommentsWebApi.Models
{
    public class CommentContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}

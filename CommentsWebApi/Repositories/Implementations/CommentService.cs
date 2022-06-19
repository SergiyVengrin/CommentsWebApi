using System.Collections.Generic;
using System.Linq;
using CommentsWebApi.Models;

namespace CommentsWebApi.Repositories
{
    public class CommentService : ICommentService
    {
        CommentContext db = new CommentContext();

        public void Add(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }


        public Comment Delete(int commentId)
        {
            Comment comment = db.Comments.Where(c => c.Id == commentId).FirstOrDefault();
            if (comment != null)
            {
                db.Comments.Remove(comment);
                db.SaveChanges();
            }

            return comment;
        }


        public IEnumerable<Comment> GetByArticleId(int articleId)
        {
            IEnumerable<Comment> comments = db.Comments.Where(c => c.ArticleId == articleId);
            if (comments != null)
            {
                return comments;
            }

            return null;
        }


        public Comment GetByCommentId(int commentId)
        {
            Comment comment = db.Comments.Where(c => c.Id == commentId).FirstOrDefault();
            if (comment != null)
            {
                return comment;
            }
            return null;
        }
    }
}

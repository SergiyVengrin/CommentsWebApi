using System.Collections.Generic;
using CommentsWebApi.Models;

namespace CommentsWebApi.Repositories
{
    public interface ICommentService
    {
        void Add(Comment comment);
        Comment Delete(int commentId);
        Comment GetByCommentId(int commentId);
        IEnumerable<Comment> GetByArticleId(int articleId);
    }
}

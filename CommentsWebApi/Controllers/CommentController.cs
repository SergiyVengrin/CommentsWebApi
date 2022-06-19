using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using CommentsWebApi.Models;
using CommentsWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CommentsWebApi.Controllers
{

    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        [Route("~/addcomment")]
        public HttpResponseMessage AddComment([FromBody] Comment comment)
        {
            if (comment != null)
            {
                commentService.Add(comment);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }


        [HttpGet]
        [Route("~/getcomments")]
        public IEnumerable<Comment> GetCommentsByArticleId(int articleId)
        {
            return commentService.GetByArticleId(articleId);
        }


        [HttpDelete]
        [Route("~/deletecomment")]
        public HttpResponseMessage DeleteComment(int commentId)
        {
            Comment comment = commentService.GetByCommentId(commentId);
            Comment deletedComment = commentService.Delete(commentId);

            if (comment == deletedComment && comment != null)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    }
}

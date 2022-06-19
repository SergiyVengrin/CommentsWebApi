using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentsWebApi.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}

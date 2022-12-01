using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF007.OverrideConfigurationByDataAnnotations.Entities
{
    [Table("tblComments")]
    public class Comment
    {
        [Column("CommentId")]
        public int Id { get; set; }
        public int TweetId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
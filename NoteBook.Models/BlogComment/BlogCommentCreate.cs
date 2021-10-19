using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoteBook.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }
        [Required(ErrorMessage = "Content is required!!!")]
        [MaxLength(300, ErrorMessage = "length should between 10-300 chars")]
        [MinLength(10, ErrorMessage = "length should between 10-300 chars")]
        public string Content { get; set; }
    }
}

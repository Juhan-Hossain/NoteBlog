using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoteBook.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Title is required!!!")]
        [MaxLength(50, ErrorMessage = "length should between 10-50 chars")]
        [MinLength(10, ErrorMessage = "length should between 10-50 chars")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is required!!!")]
        [MaxLength(3000, ErrorMessage = "length should between 300-3000 chars")]
        [MinLength(300, ErrorMessage = "length should between 300-3000 chars")]
        public string Content { get; set; }
        public int? PhotoId { get; set; }
    }
}

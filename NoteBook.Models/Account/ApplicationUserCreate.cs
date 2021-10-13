using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoteBook.Models.Account
{
    public class ApplicationUserCreate
    {
        [MaxLength(30, ErrorMessage = "Fullname should between 5-20 chars")]
        [MinLength(10, ErrorMessage = "Fullname should between 5-20 chars")]
        public string Fullname { get; set; }
        [Required(ErrorMessage ="Please provide Email address")]
        [MaxLength(30, ErrorMessage = "Email should between 5-20 chars")]
        [EmailAddress(ErrorMessage = "Email format invalid")]
        public string Email { get; set; }
    }
}

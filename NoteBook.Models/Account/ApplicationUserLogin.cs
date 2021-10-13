using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoteBook.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is required!!!")]
        [MaxLength(20,ErrorMessage ="length should between 5-20 chars")]
        [MinLength(5, ErrorMessage = "length should between 5-20 chars")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required!!!")]
        [MaxLength(50, ErrorMessage = "length should between 8-50 chars")]
        [MinLength(8, ErrorMessage = "length should between 8-50 chars")]
        public string Password { get; set; }
    }
}

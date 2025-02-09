﻿using System.ComponentModel.DataAnnotations;

namespace Practice_APIWithView_MVC_Login.Models
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
    }
}

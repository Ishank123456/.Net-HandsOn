﻿using Domain.Models;

namespace Wipro_MusicLibProject.DTO
{
    public class UserDTOCreate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ContactNo { get; set; }
        public Artist? Artist { get; set; }
    }
}

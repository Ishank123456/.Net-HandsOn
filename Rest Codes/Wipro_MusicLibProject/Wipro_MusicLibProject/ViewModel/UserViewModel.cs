using Microsoft.AspNetCore.Mvc;

namespace Wipro_MusicLibProject.ViewModel
{
    public class UserViewModel
    {
        [HiddenInput]
        public int UserId { get; set; }

        public string? Name { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ContactNo { get; set; }
        public int ArtistId { get; set; }
    }
}

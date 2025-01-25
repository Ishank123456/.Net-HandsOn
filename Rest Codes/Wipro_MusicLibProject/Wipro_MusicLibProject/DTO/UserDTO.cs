using Domain.Models;

namespace Wipro_MusicLibProject.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Name { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ContactNo { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}

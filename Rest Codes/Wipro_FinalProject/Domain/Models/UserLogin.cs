using System.ComponentModel.DataAnnotations;

namespace Wipro_FinalProject.Models
{
    public class UserLogin
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace ElevateProjectFinal.Models
{
    public class User : IdentityUser
    {
        public string Password { get; set; }
        //public string Email { get; set; }
        //public string Role { get; set; }
    }
}

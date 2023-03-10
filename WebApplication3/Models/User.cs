using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
    }
}

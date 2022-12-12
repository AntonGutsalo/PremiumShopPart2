using Microsoft.AspNetCore.Identity;

namespace Shop_Test.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace myntra_clone_api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

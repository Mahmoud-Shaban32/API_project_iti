using Microsoft.AspNetCore.Identity;

namespace API_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

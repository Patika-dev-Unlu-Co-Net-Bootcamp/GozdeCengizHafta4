using Microsoft.AspNetCore.Identity;

namespace NewsletterProject.Models.Auth
{
    public class AppUser : IdentityUser<int>
    {
        public string Memleket { get; set; }
        public bool Cinsiyet { get; set; }
    }
}

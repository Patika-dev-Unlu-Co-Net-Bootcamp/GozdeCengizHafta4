using Microsoft.AspNetCore.Identity;
using System;

namespace NewsletterProject.Models.Auth
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime OlusturulmaTarihi { get; set; }
    }
}

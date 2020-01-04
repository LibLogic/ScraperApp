using Microsoft.AspNetCore.Identity;

namespace ScraperApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ScraperAppUser class
    public class ScraperAppUser : IdentityUser
    {
        public string YahooEmail { get; set; }
        public string YahooPassword { get; set; }
    }
}

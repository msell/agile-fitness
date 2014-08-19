using Microsoft.AspNet.Identity.EntityFramework;

namespace AgileFitness.API
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
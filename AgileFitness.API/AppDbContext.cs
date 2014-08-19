using Microsoft.AspNet.Identity.EntityFramework;

namespace AgileFitness.API
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
using System.Security.Claims;

namespace AgileFitness.API
{
    public class AppUserPrincipal : ClaimsPrincipal
    {
        public AppUserPrincipal(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public string Name
        {
            get
            {
                return FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string FirstName
        {
            get
            {
                return FindFirst(ClaimTypes.GivenName).Value;
            }
        }

        public string LastName
        {
            get
            {
                return FindFirst(ClaimTypes.Surname).Value;
            }
        }
    }
}
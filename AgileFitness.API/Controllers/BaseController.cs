using System.Security.Claims;
using System.Web.Http;

namespace AgileFitness.API.Controllers
{
    public abstract class BaseController : ApiController
    {
        public AppUserPrincipal CurrentUser
        {
            get
            {
                return new AppUserPrincipal(base.User as ClaimsPrincipal);
            }
        }
    }
}
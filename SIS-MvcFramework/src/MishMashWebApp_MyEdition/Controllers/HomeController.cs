using SIS.HTTP.Responses;
using SIS.MvcFramework;

namespace MishMashWebApp_MyEdition.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet("/Home/Index")]
        public IHttpResponse Index()
        {
            if (User.IsLoggedIn)
            {
                return this.View("Home/LoggedInIndex");
            }
            else
            {
                return this.View("Home/Index");
            }
        }
    }
}

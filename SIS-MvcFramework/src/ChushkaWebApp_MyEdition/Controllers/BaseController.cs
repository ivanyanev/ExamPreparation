using ChushkaWebApp_MyEdition.Data;
using SIS.MvcFramework;

namespace ChushkaWebApp_MyEdition.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.Db = new ApplicationDbContext();
        }

        public ApplicationDbContext Db { get; }
    }
}

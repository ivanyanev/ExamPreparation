using ChushkaWebApp_MyEdition.ViewModels.Home;
using SIS.HTTP.Responses;
using System.Linq;

namespace ChushkaWebApp_MyEdition.Controllers
{
    public class HomeController : BaseController
    {
        public IHttpResponse Index()
        {
            if (this.User.IsLoggedIn)
            {
                var products = this.Db.Products.Select(
                    x => new ProductViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        Price = x.Price
                    })
                    .ToList();

                var model = new IndexViewModel
                {
                    Products = products
                };
                return this.View("/Home/LoggedInIndex", model);
            }
            return this.View();
        }
    }
}

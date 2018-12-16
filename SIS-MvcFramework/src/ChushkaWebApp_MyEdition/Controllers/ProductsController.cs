using ChushkaWebApp_MyEdition.ViewModels.Products;
using SIS.HTTP.Responses;
using System.Linq;

namespace ChushkaWebApp_MyEdition.Controllers
{
    public class ProductsController : BaseController
    {
        public IHttpResponse Details(int id)
        {
            var viewModel = this.Db.Products
                .Select(x => new ProductDetailsViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type,
                    Price = x.Price,
                    Description = x.Description
                })
                .FirstOrDefault(x => x.Id == id);

            if (viewModel == null)
            {
                return this.BadRequestError("Invalid product id");
            }

            return this.View(viewModel);
        }
    }
}

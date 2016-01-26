using System.Linq;
using System.Web.Mvc;
using MusicStore.DAL.Interfaces;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    
    public class ProductController : Controller {
        private readonly IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository) {
            this.repository = productRepository;
        }

        public ViewResult List(string category,int page = 1) {
            ProductsListViewModel model = new ProductsListViewModel {
                Products = repository.Products
               .Where(p => category == null || p.Category == category)
               .OrderBy(p => p.ProductID)
               .Skip((page - 1) * PageSize)
               .Take(PageSize),
                PagingInfo = new InformationPage {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);




          

        }
    }
}
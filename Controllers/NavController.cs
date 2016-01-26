using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.DAL.Interfaces;

namespace MusicStore.Controllers
{
    public class NavController: Controller
    {
        private IProductRepository repository;

        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {

            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products
                            .Select(x => x.Category)
                            .Distinct()
                            .OrderBy(x => x);

            return PartialView("FlexMenu", categories);
        }

        public ActionResult List(string s)
        {
            return RedirectToAction("List", "Product");
        }
    }
}
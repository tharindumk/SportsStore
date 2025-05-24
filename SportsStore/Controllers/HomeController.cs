using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {            
            this.repository = repo;            
        }

        public IActionResult Index(int productpage = 1)
        {
            //return View(repository.Products.OrderBy(p => p.ProductID).Skip((productpage - 1) * PageSize).Take(PageSize));
            return View(new ProductsListViewModel
            {
                Products = repository.Products.OrderBy(p => p.ProductID).Skip((productpage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productpage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
        }
    }
}

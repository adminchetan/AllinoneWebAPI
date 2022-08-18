using product.IBL;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllinOneAPI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository iproductRepository;

        public HomeController(IProductRepository _iproductRepository)
        {
            iproductRepository = _iproductRepository;
        }


        public ActionResult Index()
        {

            IEnumerable<ProductModel> listProductModel = iproductRepository.GetAllBooks();

            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult AddBook()
        {

            ProductModel objProductmodel = new ProductModel()
            {
                Name = "NEw Book From Controller",
                Price = 100,
                Quantity = 50,
                Status = true,
                Description = "This Book Has Been Added From Controller Call"
            };
            int result = iproductRepository.AddBook(objProductmodel);
            return View();
        }
    }
}

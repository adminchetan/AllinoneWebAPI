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

        [HttpPost]
        public ActionResult AddBook(ProductModel productModel)
        {

           

            ProductModel objProductmodel = new ProductModel()
            {
                Name = productModel.Name,
                Price = productModel.Price,
                Quantity = productModel.Quantity,
                Status = true,
                Description = productModel.Description
            };
            int result = iproductRepository.AddBook(objProductmodel);
            return View();
        }


        public ActionResult GetAllData()
        {
            return View();
        }


    }
}

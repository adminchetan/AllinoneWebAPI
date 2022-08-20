using product.IBL;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AllinOneAPI.Controllers
{
    public class dataController : ApiController

    {

        private IProductRepository _iproductRepository; //use unityapi 

        public dataController(IProductRepository productRepository)
        {

            _iproductRepository = productRepository;
        }


        // GET api/values
        public IEnumerable<ProductModel> Get()
     {
            IEnumerable<ProductModel> listProductModel = _iproductRepository.GetAllBooks();
            return listProductModel;
        }
    }
}

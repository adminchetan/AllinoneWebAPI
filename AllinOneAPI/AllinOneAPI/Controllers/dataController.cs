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


        //// GET api/values
   
        public IEnumerable<ProductModel> Get()
     {
            IEnumerable<ProductModel> listProductModel = _iproductRepository.GetAllBooks();
            return listProductModel;
        }
     
        public HttpResponseMessage Postdata(ProductModel productModel)
        {
            try
            {
                //ProductModel objProductmodel = new ProductModel()
                //{
                //    Name = productModel.Name,
                //    Price = productModel.Price,
                //    Quantity = productModel.Quantity,
                //    Status = true,
                //    Description = productModel.Description
                //};
                int result = _iproductRepository.UpdateProductById(productModel);
               

                var response = Request.CreateResponse(HttpStatusCode.Created);

                return response;
            }

            catch (Exception ex)
            {
                var response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "The Request not Successed");
                return response;
            }
        

         
        }


        public HttpResponseMessage PutProductById(ProductModel productModel)
        {
            try
            {
                //ProductModel objProductmodel = new ProductModel()
                //{
                //    Name = productModel.Name,
                //    Price = productModel.Price,
                //    Quantity = productModel.Quantity,
                //    Status = true,
                //    Description = productModel.Description
                //};
                int result = _iproductRepository.UpdateProductById(productModel);
               

                var response = Request.CreateResponse(HttpStatusCode.Created);

                return response;
            }

            catch (Exception ex)
            {
                var response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "The Request not Successed");
                return response;
            }
        

         
        }





        public HttpResponseMessage Deletedata(ProductModel productModel)
        {
            try
            {
                ProductModel objProductmodel = new ProductModel()
                {
                    id = productModel.id,
                  
                };

                int result = _iproductRepository.DeleteBook(objProductmodel);
               

                var response = Request.CreateResponse(HttpStatusCode.OK);

                return response;
            }

            catch (Exception ex)
            {
                var response = Request.CreateErrorResponse(HttpStatusCode.NotFound, "The Request not Successed");
                return response;
            }
        

         
        }


    }
}

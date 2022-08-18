using product.IBL;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Data;


namespace Product.BL
{
    
   public class ProductRepository : IProductRepository
    {

        private uttaraon_neerajEntities objuttaraon_neerajEntities;
         
        public ProductRepository()    //constructor 
        {
            objuttaraon_neerajEntities = new uttaraon_neerajEntities();
        }
               
        public int AddBook(ProductModel productModel)
        {

            Data.Product objProduct = new Data.Product()
            {
                Name = productModel.Name,
                Price=productModel.Price,
                Quantity=productModel.Quantity,
                Status=productModel.Status,
                Description=productModel.Description

            };
            objuttaraon_neerajEntities.Products.Add(objProduct);
            return objuttaraon_neerajEntities.SaveChanges();
      
        }

        public IEnumerable<ProductModel> GetAllBooks()
        {

            try
            {
                IEnumerable<ProductModel> listofProducts = (from objProduct in objuttaraon_neerajEntities.Products
                                                            select new ProductModel()
                                                            {
                                                                Name = objProduct.Name,
                                                                Price = objProduct.Price,
                                                                id = objProduct.id,
                                                                Quantity=objProduct.Quantity
                                                            }).ToList();
                return listofProducts;
            }

            catch(Exception ex)
            {
                IEnumerable<ProductModel> listofProducts = (from objProduct in objuttaraon_neerajEntities.Products
                                                            select new ProductModel()
                                                            {
                                                                Name = "Some Technical Issue",
                                                           
                                                            }).ToList();
                return listofProducts;
            }
       
        
        }

        public ProductModel GetProductById(int id)
        {

            ProductModel listofProducts = new ProductModel();
            return listofProducts;
        }                               
    }
}

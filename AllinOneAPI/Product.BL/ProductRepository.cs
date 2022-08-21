using product.IBL;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Data;
using System.Data.SqlClient;

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
                Price = productModel.Price,
                Quantity = productModel.Quantity,
                Status = productModel.Status,
                Description = productModel.Description

            };
            objuttaraon_neerajEntities.Products.Add(objProduct);
            return objuttaraon_neerajEntities.SaveChanges();

        }

        public int DeleteBook(ProductModel productModel)
        {
            Data.Product objproduct = new Data.Product()
            {
                id = productModel.id
            };

            var i = (from pro in objuttaraon_neerajEntities.Products

                     where pro.id == productModel.id
                     select pro).FirstOrDefault();
            objuttaraon_neerajEntities.Products.Remove(i);
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
                                                                Quantity = objProduct.Quantity
                                                            }).ToList();
                return listofProducts;
            }

            catch (Exception ex)
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

        public int UpdateProductById(ProductModel productModel)
        {


            var query = from pro in objuttaraon_neerajEntities.Products where pro.id == productModel.id select pro;
            foreach (var product in query)
            {

                product.Name = productModel.Name;
                product.Price = productModel.Price;
                product.Quantity = productModel.Quantity;
                product.Description = productModel.Description;
            }


            try
            {
                return objuttaraon_neerajEntities.SaveChanges();
            }
            catch (Exception e)
            {
                return 1;
            }



        }
    }
}




  

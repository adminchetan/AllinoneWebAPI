using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.IBL
{
   public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAllBooks();

        int AddBook(ProductModel productModel);

        int DeleteBook(ProductModel productModel);

        ProductModel GetProductById(int id);
    }
}

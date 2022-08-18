using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Model;

namespace Product.BL
{
    public interface IProductRepository

    {

        IEnumerable<ProductModel> GellAllBooks();
        int AddBook(ProductModel productModel);
        ProductModel GetPRoductById(int id);
    }
}

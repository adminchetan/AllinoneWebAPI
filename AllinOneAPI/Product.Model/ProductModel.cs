using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{
    public class ProductModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public Nullable<double> Price { get; set; }

        public Nullable<int> Quantity { get; set; }

        public bool Status { get; set; }

        public string Description { get; set; }
     
            }
}

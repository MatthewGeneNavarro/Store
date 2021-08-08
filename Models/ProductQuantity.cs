using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class ProductQuantity
    {
        //Going to act as a cart
        //This table will contain qualities of the Product table in SQL behavior

        public int ProductQuantityId { get; set; }      
        public int ProductId { get; set; }
        public List<Product> product { get; set; }

    }
}

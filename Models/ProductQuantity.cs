using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    class ProductQuantity
    {
        public int ProductQuantityId { get; set; }

        //Implement if you have time
        //Tracks customer name and customer order
        //public string FirstName { get; set; }
        //public string Lastname { get; set; }


        //Throws foreign key constraint error
        //public int ProductId { get; set; }
        public List<Product> Products { get; set; }

    }
}

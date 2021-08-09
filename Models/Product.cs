using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductAmount { get; set; }

        // Throws foreign key constraint error
        //public int ProductQuantityId { get; set; }
        public ProductQuantity ProductQuantity { get; set; }


    }
}

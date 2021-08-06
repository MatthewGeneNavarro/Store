﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductAmount { get; set; }

        // foreignkey of ProductQuantityTable
        public int ProductQuantityId { get; set; }
        public ProductQuantity ProductInCart { get; set; }
    }
}

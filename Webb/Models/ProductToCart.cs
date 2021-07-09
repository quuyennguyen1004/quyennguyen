    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Views.Domain;

namespace Webb.Models
{
    public class ProductToCart
    {
        public List<Product> products { get; set; }

        public Order order { get; set; }
    }
}

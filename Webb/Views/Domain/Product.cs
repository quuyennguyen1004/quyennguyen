using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Webb.Models;

namespace Webb.Views.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductImage { get; set; }
        public string Color { get; set; }
        public string Ram { get; set; }
        public string Batterycapacity { get; set; }

        public string Screen { get; set; }
        public string Rearcamera { get; set; }
        public string Frontcamera { get; set; }
        public string Chipset { get; set; }
        public double ProductPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public string Descriptions { get; set; }
       public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<PurcharseHis> PurcharseHiss { get; set; }

        
    }
}

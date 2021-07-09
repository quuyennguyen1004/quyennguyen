using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Webb.Models;

namespace Webb.Views.Domain
{
    public class Comment
    {[Key]
        public int ComId { get; set; }
        public virtual Product Product { get; set; }
        public Nullable<int> ProductId { get; set; }
        [ForeignKey("ProductId")]
        public string Content { get; set; }       
        public DateTime Created { get; set; }
        public int Rating { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }                                 
    }
}

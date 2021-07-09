using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Webb.Views.Domain;

namespace Webb.Models
{
    public class User : IdentityUser
    {       
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string FullName { set; get; }
        public string Dienthoai { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { set; get; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

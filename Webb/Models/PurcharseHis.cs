using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Views.Domain;

namespace Webb.Models
{
    public class PurcharseHis
    {
        public int PurcharseHisId { get; set; }
        public virtual Order Order { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}

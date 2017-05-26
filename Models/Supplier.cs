using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giuliano.Paula.Models
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
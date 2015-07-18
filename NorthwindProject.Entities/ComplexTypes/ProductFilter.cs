using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities.ComplexTypes
{
    public class ProductFilter
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}

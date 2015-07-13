using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities.ComplexTypes
{
    public class ProductDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }
}

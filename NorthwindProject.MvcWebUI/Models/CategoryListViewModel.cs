using NorthwindProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthwindProject.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public int? CurrentCategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}

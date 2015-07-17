using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities.Concrete;
using NorthwindProject.Entities.ComplexTypes;


namespace NorthwindProject.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(ProductFilter filter);
        Product GetById(int productId);
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void DeleteById(int productId);
    }
}

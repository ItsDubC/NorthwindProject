using NorthwindProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        public List<Entities.Concrete.Product> GetAll(Entities.ComplexTypes.ProductFilter filter)
        {
            throw new NotImplementedException();
        }

        public Entities.Concrete.Product GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.Product> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Add(Entities.Concrete.Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Concrete.Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Concrete.Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

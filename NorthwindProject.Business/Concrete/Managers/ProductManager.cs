using NorthwindProject.Business.Abstract;
using NorthwindProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities.Concrete;
using NorthwindProject.Business.ValidationRules;
using NorthwindProject.Business.ValidationRules.FluentValidation;

namespace NorthwindProject.Business.Concrete.Managers
{
    public class ProductManager : IProductService  //Implement business logic here
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll(Entities.ComplexTypes.ProductFilter filter)
        {
            int? categoryId = filter.CategoryId;

            if (categoryId != null)
            { 
                return _productDal.GetList(filter: p => p.CategoryId == categoryId, 
                    orderBy:o=>o.OrderBy(p=>p.Id), 
                    page:filter.Page, 
                    pageSize:filter.PageSize);
            }
            else
            {
                return _productDal.GetList(
                    orderBy: o => o.OrderBy(p => p.Id),
                    page: filter.Page,
                    pageSize: filter.PageSize);
            }
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.Id == productId);
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            //return _productDal.GetList(filter:p=>p.CategoryId == categoryId);
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            FluentValidatorTool.Validate(new ProductValidator(), product);
            ProductNameCheck(product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            ProductNameCheck(product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        //public void DeleteById(int productId)
        //{
        //    //_productDal.Delete()
        //}


        public List<Product> GetByProductName(string name)
        {
            return _productDal.GetList(p => p.Name.Contains(name));
        }


        public int GetProductsCountByCategory(int? categoryId)
        {
            return _productDal.GetProductCountByCategory(categoryId);
        }

        private void ProductNameCheck(Product product)
        {
            bool isThereAnyProductNameWithSameName = _productDal.GetList(p => p.Name == product.Name).Any();

            if (isThereAnyProductNameWithSameName)
            {
                throw new Exception("There is already a product with the same name.");
            }
        }
    }
}

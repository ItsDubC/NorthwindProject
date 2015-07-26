using Ninject;
using NorthwindProject.Business.Abstract;
using NorthwindProject.Business.Concrete.Managers;
using NorthwindProject.DataAccess.Abstract;
using NorthwindProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindProject.MvcWebUI.DependencyResolvers
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            _kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            _kernel.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            _kernel.Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}
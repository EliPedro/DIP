using Ninject;
using System.Web.Mvc;
using System;
using System.Web.Routing;
using Store.Dominio.Interface;
using Store.Dominio.Repositorio;

namespace Store.WebUI.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectIkernel;

        public NinjectControllerFactory()
        {
            ninjectIkernel = new StandardKernel();
            AdBinding();
        }
        
        protected override IController  GetControllerInstance(RequestContext resquestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectIkernel.Get(controllerType);
        }

        private void AdBinding()
        {
            ninjectIkernel.Bind<IProduto>().To<ProdutoRepositorio>();
            ninjectIkernel.Bind<ICategoria>().To<CategoriaRepositorio>();
        }
    }
}
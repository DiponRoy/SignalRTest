using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Ninject;
using SDT.Ioc;

namespace SDT
{
    public class IocConfig
    {
        public static void Register(HttpConfiguration config)
        {
            IKernel kernel = new StandardKernel(new StdNinjectModule());
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}
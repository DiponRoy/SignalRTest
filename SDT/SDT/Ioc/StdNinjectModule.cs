using Ninject.Modules;
using SDT.Db;
using SDT.Uow;

namespace SDT.Ioc
{
    public class StdNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISdtDbContext>().To<SdtDbMapContext>();
            Bind<ISdtUow>().To<SdtUow>();
        }
    }
}
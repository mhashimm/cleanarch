using Autofac;
using MSIRS.Core.Interfaces;
using MSIRS.Core.Services;

namespace MSIRS.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}

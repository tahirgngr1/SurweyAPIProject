using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DataAccess.Implements;

namespace Business
{
    public class AutofacModuleContainer : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SurweyDbContext>().As<SurweyDbContext>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
             
                }).SingleInstance();
        }

    }
}
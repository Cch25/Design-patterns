using DependecyInjection.Implementation;
using DependecyInjection.Services;

namespace DependecyInjection
{
    public class TestDI
    {
        public void TestDependecyInjection()
        {
            DependencyContainer container = new DependencyContainer();
            container.AddTransient<ServiceA>();
            container.AddTransient<ServiceB>();
            container.AddSingleton<ServiceC>();

            DependecyResolver resolver = new DependecyResolver(container);
            
            ServiceA service1 = resolver.GetService<ServiceA>();
            service1.Print();
            ServiceB service2 = resolver.GetService<ServiceB>();
            service2.ShowMessage();
        }
    }
}

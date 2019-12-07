using ServiceLocator.Models;
using ServiceLocator.Services;
namespace ServiceLocator
{
    public class ServiceLocatorPattern
    {
        private readonly ServiceLocator.ServiceLocator sl = new ServiceLocator.ServiceLocator();
        public void LocateServiceA()
        {
            sl.GetService<ServiceA>().BaseDisplay(new Model { Name = "Elsa" });
            sl.GetService<ServiceA>().Display();
            sl.GetService<ServiceB>().Show();
            sl.GetService<ServiceC>().Greet();

        }
    }
}

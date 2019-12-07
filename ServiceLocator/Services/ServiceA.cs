using ServiceLocator.Models;
using System;

namespace ServiceLocator.Services
{
    public class ServiceA : BaseService<Model>
    {
        public void Display()
        {
            Console.WriteLine("Service locator from Service A");
        }
    }
}

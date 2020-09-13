using System;

namespace DependecyInjection.Services
{
    public class ServiceB
    {
        ServiceC _serviceC;
        int _random;
        public ServiceB(ServiceC message)
        {
            _serviceC = message;
            _random = new Random().Next();
        }

        public void ShowMessage()
        {
            Console.WriteLine($"Hello #{_random} World {_serviceC.Message()}");
        }
    }
}

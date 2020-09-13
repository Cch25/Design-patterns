using System;

namespace DependecyInjection.Services
{
    public class ServiceC
    {
        int _random;
        public ServiceC()
        {
            _random = new Random().Next();
        }

        public string Message()
        {
            return $"Hi #{_random}";
        }
    }
}

using System;
using System.Collections.Generic;

namespace ServiceLocator.ServiceLocator
{
    public class ServiceLocator : IServiceLocator
    {
        //map that contains pair of interfaces and references to concrete implemantation
        private readonly IDictionary<string, dynamic> _services = new Dictionary<string, dynamic>();

        public T GetService<T>() where T : class
        {
            try
            {
                string type = typeof(T).Name;
                if (_services.ContainsKey(type))
                {
                    return (T)_services[type];
                }
                _services.Add(type, Activator.CreateInstance(typeof(T)));
                return (T)_services[type];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}

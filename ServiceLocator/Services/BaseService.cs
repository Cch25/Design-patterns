using ServiceLocator.Models;
using System;

namespace ServiceLocator.Services
{
    public class BaseService<T>
    {
        public T BaseDisplay(T model)
        {
            if (model is Model)
            {
                Model m = model as Model;
                Console.WriteLine($"Base service shows {m.Name}");
            }
            return model;
        }
    }
}

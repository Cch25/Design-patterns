using System;
using System.Collections.Generic;
using System.Linq;

namespace DependecyInjection.Implementation
{
    public class DependencyContainer
    {
        List<Dependency> _dependencies;
        public DependencyContainer()
        {
            _dependencies = new List<Dependency>();
        }
        public void AddSingleton<T>()
        {
            _dependencies.Add(new Dependency(typeof(T), DependecyLifetime.Singleton));
        }
        public void AddScoped<T>()
        {
            _dependencies.Add(new Dependency(typeof(T), DependecyLifetime.Scoped));
        }
        public void AddTransient<T>()
        {
            _dependencies.Add(new Dependency(typeof(T), DependecyLifetime.Transient));
        }
        public Dependency GetDependency(Type type)
        {
            return _dependencies.First(x => x.Type.Name == type.Name);
        }
    }
}

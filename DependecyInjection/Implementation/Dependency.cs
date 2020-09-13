using System;

namespace DependecyInjection.Implementation
{
    public class Dependency
    {
        public Type Type { get; }
        public DependecyLifetime DependecyLifetime { get; }
        public object Implementation { get; set; }
        public bool Implemented { get; set; }
        public Dependency(Type type, DependecyLifetime dependecyLifetime)
        {
            Type = type;
            DependecyLifetime = dependecyLifetime;
        }
        public void AddImplementation(object implementation)
        {
            Implementation = implementation;
            Implemented = true;
        }

    }
}

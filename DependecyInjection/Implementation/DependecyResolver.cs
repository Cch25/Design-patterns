using System;
using System.Linq;
using System.Reflection;

namespace DependecyInjection.Implementation
{
    public class DependecyResolver
    {
        DependencyContainer _dependencyContainer;
        public DependecyResolver(DependencyContainer dependencyContainer)
        {
            _dependencyContainer = dependencyContainer;
        }
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        private object GetService(Type type)
        {
            Dependency dependecy = _dependencyContainer.GetDependency(type);
            ConstructorInfo constructor = dependecy.Type.GetConstructors().Single();
            ParameterInfo[] parameters = constructor.GetParameters().ToArray();

            if (parameters.Length > 0)
            {
                object[] parameterImplementations = new object[parameters.Length];
                for(int i = 0; i < parameters.Length; i++)
                {
                    parameterImplementations[i] = GetService(parameters[i].ParameterType);
                }
                return CreateImplementation(dependecy, t => Activator.CreateInstance(t, parameterImplementations));
            }
            return CreateImplementation(dependecy, t => Activator.CreateInstance(t));
        }

        private object CreateImplementation(Dependency dependecy, Func<Type, object> factory)
        {
            if (dependecy.Implemented)
            {
                return dependecy.Implementation;
            }
            object implementation = factory(dependecy.Type);
            if (dependecy.DependecyLifetime == DependecyLifetime.Singleton)
            {
                dependecy.AddImplementation(implementation);
            }
            return implementation;
        }
    }
}

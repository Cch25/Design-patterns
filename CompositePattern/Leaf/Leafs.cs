using System;
using DesignPatterns.Abstract;

namespace DesignPatterns.Composite.Leaf
{
    public class Leafs : IComponent
    {
        public Leafs(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public IComponent AddComponent(IComponent component)
        {
            Console.WriteLine("Files can't add folders"); ;
            return null;
        }
        public void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)}+{Name}");
        }
        public void RemoveComponent(IComponent component)
        {
            Console.WriteLine("Files can't remove folders");
        }
    }
}


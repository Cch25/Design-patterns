using System;
using System.Collections.Generic;
using DesignPatterns.Abstract;

namespace DesignPatterns.Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public IComponent AddComponent(IComponent component)
        {
            components.Add(component);
            return component;
        }
        /// <summary>
        /// Making use of Inheritance now we have stored in our list of all kinds of sub-components.
        /// We have Folders(Composite) and we also have Files (Leafs).
        /// In every Composite we also have Leafs, so we can recursively go through them.
        /// </summary>
        /// <param name="depth">Allows you to indent the Composite(root) node</param>
        public void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)}{Name}");
            foreach (IComponent component in components)
            {
                component.Display(depth + 2);
            }
        }
        public void RemoveComponent(IComponent component)
        {
            components.Remove(component);
        }
    }
}


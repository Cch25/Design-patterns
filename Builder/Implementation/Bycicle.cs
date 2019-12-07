using Builder.Implementation.ConcreteImplementation;
using System;

namespace Builder.Implementation
{
    public class Bycicle : Parts, IParts
    {
        public void AddAntiTheftDevice()
        {
            Console.WriteLine("My Bycicle has been equipped with a new anti theft device.");
        }
    }
}

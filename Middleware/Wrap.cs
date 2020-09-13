using System;

namespace Middleware
{
    public class Wrap<T> : Pipe<T>
    {
        public Wrap(Action<T> action) : base(action)
        {
        }

        public override void Handle(T message)
        {
            Console.WriteLine("\tStarting wrap pipe");
            _action(message);
            Console.WriteLine("\tEnds wrap pipe");
        }
    }

}

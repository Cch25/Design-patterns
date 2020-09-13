using System;

namespace Middleware
{
    public class Try<T> : Pipe<T>
    {
        public Try(Action<T> action) : base(action)
        {
        }

        public override void Handle(T message)
        {
            try
            {
                Console.WriteLine("\tTrying pipe starting");
                _action(message);
                Console.WriteLine("\tTrying pipe ending");
            }
            catch (Exception){}
        }
    }

}

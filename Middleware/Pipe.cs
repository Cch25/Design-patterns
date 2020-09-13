using System;

namespace Middleware
{
    public abstract class Pipe<T>
    {
        protected Action<T> _action;
        public Pipe(Action<T> action)
        {
            _action = action;
        }
        public abstract void Handle(T message);
    }

}

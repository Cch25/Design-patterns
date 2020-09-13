using System;

namespace Middleware.PipeBuild
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

using System;
using System.Collections.Generic;

namespace Middleware
{
    public class PipeBuilder<T>
    {
        private readonly Action<T> _mainAction;
        private readonly List<Type> _pipeTypes;

        public PipeBuilder(Action<T> mainAction)
        {
            _mainAction = mainAction;
            _pipeTypes = new List<Type>();
        }
        public PipeBuilder<T> AddPipe(Type pipeType)
        {
            _pipeTypes.Add(pipeType);
            return this;
        }
        public Action<T> Build()
        {
            return CreatePipe(0);
        }

        private Action<T> CreatePipe(int index)
        {
            if(index < _pipeTypes.Count - 1)
            {
                Action<T> childPipeHandle = CreatePipe(index + 1);
                Pipe<T> pipe = (Pipe<T>)Activator.CreateInstance(_pipeTypes[index], childPipeHandle);
                return pipe.Handle;
            }
            else
            {
                Pipe<T> finalPipe = (Pipe<T>)Activator.CreateInstance(_pipeTypes[index], _mainAction);
                return finalPipe.Handle;
            }

        }
    }
}

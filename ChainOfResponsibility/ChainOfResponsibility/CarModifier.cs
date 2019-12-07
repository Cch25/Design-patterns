using ChainOfResponsibility.Mediator;
using System;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class CarModifier : IDisposable
    {
        protected Infrastructure _infrastructure;
        protected Car _car;
        public CarModifier(Car car, Infrastructure infrastructure)
        {
            _infrastructure = infrastructure;
            _car = car;
            _infrastructure.Queries += Handle;
        }

        public abstract void Handle(object sender, Query e);

        public void Dispose()
        {
            _infrastructure.Queries -= Handle;
        }
    }
}

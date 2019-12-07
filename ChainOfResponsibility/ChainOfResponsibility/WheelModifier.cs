using ChainOfResponsibility.Mediator;
using System;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class WheelModifier : CarModifier
    {
        public int _price { get; }
        public WheelModifier(Car car, Infrastructure infrastructure,int price) : base(car, infrastructure)
        {
            _price = price;
        }
        public override void Handle(object sender, Query e)
        {
            if (!e.Name.Contains(VehicleType.DACIA.ToString()))
            {
                Console.WriteLine("With wheels");
                e.Price += _price;
            }
        }
    }
}

using ChainOfResponsibility.Mediator;
using System;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class SpoilerModifier : CarModifier
    {
        private readonly int addPrice;

        public SpoilerModifier(Car car, Infrastructure infrastructure, int addPrice) : base(car, infrastructure)
        {
            this.addPrice = addPrice;
        }

        public override void Handle(object sender, Query e)
        {
            bool isSpoilerSupported = (e.Year > DateTime.Now.AddYears(-5).Year && e.VehicleType != VehicleType.DACIA) ? true : false;
            if (isSpoilerSupported)
            {
                Console.WriteLine("With spoiler");
                e.Price += addPrice;
            }
        }
    }
}

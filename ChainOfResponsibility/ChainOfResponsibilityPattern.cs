using ChainOfResponsibility.ChainOfResponsibility;
using ChainOfResponsibility.Mediator;
using System;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityPattern
    {
        public void ChainOfResponsibilityDemo()
        {
            Infrastructure infrastructure = new Infrastructure();
            Car car = new Car(infrastructure, 2016, "A6", VehicleType.BMW, 5_000);
            using (new SpoilerModifier(car, infrastructure, 200))
            {
                Console.WriteLine($"\t{car.Price:C}");
            }
            using (new WheelModifier(car, infrastructure, 150))
            {
                Console.WriteLine($"\t{car.Price:C}");
            }

            Console.WriteLine("Original price");
            Console.WriteLine($"\t{car.Price:C}");
        }
    }
}

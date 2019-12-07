using Decorator.Decorator;
using System;

namespace Decorator
{
    public class DecoratorPattern
    {
        public void SquareDecorator(int length)
        {
            IShape square = new Square(length);
            IShape coloredSquare = new ColorDecorator(square, "blue");
            IShape opacitySquare = new OpacityDecorator(coloredSquare, 0.21f);
            Console.WriteLine(opacitySquare.ShapeDetails());
        }
    }
}

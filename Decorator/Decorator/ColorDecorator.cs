namespace Decorator.Decorator
{
    public class ColorDecorator : IShape
    {
        private readonly IShape _shape;
        private readonly string _color;
        public ColorDecorator(IShape shape, string color)
        {
            _shape = shape;
            _color = color;
        }
        public string ShapeDetails()
        {
            return $"{_shape.ShapeDetails()} and the color is {_color}";
        }
    }
}

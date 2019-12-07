namespace Decorator.Decorator
{
    public class OpacityDecorator : IShape
    {
        private IShape _shape;
        private float _opacity;
        public OpacityDecorator(IShape shape, float opacity)
        {
            _shape = shape;
            _opacity = opacity;
        }
        public string ShapeDetails()
        {
            return $"{_shape.ShapeDetails()} with a transparency of {_opacity * 100.0f}%";
        }
    }
}

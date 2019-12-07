namespace Decorator.Decorator
{
    public class Square : IShape
    {
        public int Length { get; set; }
        public Square(int length)
        {
            Length = length * 2;
        }
        public string ShapeDetails()
        {
            return $"Length of the square is {Length} ";
        }
    }
}

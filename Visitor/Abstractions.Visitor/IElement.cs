namespace Visitor.Abstractions.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

namespace DesignPatterns.Abstract
{
    public interface IComponent
    {
        IComponent AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
        void Display(int depth);
    }
}


namespace IteratorExample.Pattern
{
    public interface IIterator<T> where T : class
    {
        T Next();
        bool Done();
        T CurrentItem();
        T FirstItem();
    }
}

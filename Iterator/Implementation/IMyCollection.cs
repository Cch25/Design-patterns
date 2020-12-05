using IteratorExample.Pattern;

namespace IteratorExample.Implementation
{
    public interface IMyCollection<T> where T : class
    {
        Iterator<T> CreateIterator(); 
    }
}

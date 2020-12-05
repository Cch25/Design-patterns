using IteratorExample.Implementation;

namespace IteratorExample.Pattern
{
    public class Iterator<T> : IIterator<T> where T : class
    {
        private readonly MyCollection collection;
        private int step = 0;
        public Iterator(MyCollection collection) => this.collection = collection;
        public T CurrentItem() => collection[step] as T;
        public bool Done() => step > collection.Count - 1;
        public T FirstItem() => collection[0] as T;
        public T Next() => Done() ? collection[collection.Count - 1] as T : collection[step++] as T;
    }
}

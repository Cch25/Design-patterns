using IteratorExample.Pattern;
using System.Collections.Generic;

namespace IteratorExample.Implementation
{
    public class MyCollection : IMyCollection<Person>
    {
        private readonly List<Person> _collection = new List<Person>();
        public Iterator<Person> CreateIterator() => new Iterator<Person>(this);
        public int Count => _collection.Count; 
        public Person this[int i]
        {
            get => _collection[i];
            set => _collection.Add(value);
        }
    }
}

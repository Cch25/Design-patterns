using IteratorExample.Implementation;
using IteratorExample.Pattern;
using System;

namespace IteratorExample
{
    public class IteratorPattern
    {
        public void TestIterator()
        {
            MyCollection mc = new MyCollection();
            mc[0] = new Person() { Name = "Elsa", Age = 18 };
            mc[1] = new Person() { Name = "Emma", Age = 19 };
            mc[2] = new Person() { Name = "Anna", Age = 20 };
            mc[3] = new Person() { Name = "Mary", Age = 21 };
            Iterator<Person> iterator = mc.CreateIterator();
            while (!iterator.Done())
            {
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }
        }
    }
}

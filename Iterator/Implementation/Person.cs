namespace IteratorExample.Implementation
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Name} ({Age} years old)"; 
    }
}

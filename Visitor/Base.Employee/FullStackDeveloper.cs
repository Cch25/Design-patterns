namespace Visitor.BaseEmployee
{
    public class FullStackDeveloper : Employee
    {
        public FullStackDeveloper(int paidTimeOffDays, string name, double salary)
            : base(paidTimeOffDays, name, salary)
        {
        }
        public FullStackDeveloper() : this(23, "Culai", 5_000) { }
    }
}

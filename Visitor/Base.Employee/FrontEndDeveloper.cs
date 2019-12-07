namespace Visitor.BaseEmployee
{
    public class FrontEndDeveloper : Employee
    {
        public FrontEndDeveloper(int paidTimeOffDays, string name, double salary)
            : base(paidTimeOffDays, name, salary)
        {
        }
        public FrontEndDeveloper() : this(20, "Culai", 3_000) { }
    }
}

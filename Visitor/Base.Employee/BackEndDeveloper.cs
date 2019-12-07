namespace Visitor.BaseEmployee
{
    public class BackEndDeveloper : Employee
    {
        public BackEndDeveloper(int paidTimeOffDays, string name, double salary) 
            : base(paidTimeOffDays, name, salary)
        {
        }
        public BackEndDeveloper():this(21,"Culai",4_000)
        {
        }
    }
}

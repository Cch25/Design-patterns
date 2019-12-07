using System;
using Visitor.Abstractions.Visitor;
using Visitor.BaseEmployee;

namespace Visitor.ExtendEmployee.Benefits
{
    public class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;
            employee.PaidTimeOffDays += 5;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.PaidTimeOffDays}");
        }
    }
}

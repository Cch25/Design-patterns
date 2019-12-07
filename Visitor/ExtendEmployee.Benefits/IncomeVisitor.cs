using System;
using Visitor.Abstractions.Visitor;
using Visitor.BaseEmployee;

namespace Visitor.ExtendEmployee.Benefits
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;
            employee.Salary *= 0.25;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}\'s new salary is {employee.Salary}");
        }
    }
}

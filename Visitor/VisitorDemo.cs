using System;
using Visitor.BaseEmployee;
using Visitor.ExtendEmployee.Benefits;

namespace Visitor
{
    public class VisitorDemo
    {
        public void VisitorPattern()
        {
            Employee employee = new Employee(10, "Culai", 500);
            employee.Accept(new IncomeVisitor());
            employee.Accept(new PaidTimeOffVisitor());
            Console.WriteLine();

            Employees employees = new Employees();
            employees.Attach(new FrontEndDeveloper());
            employees.Attach(new BackEndDeveloper());
            employees.Attach(new FullStackDeveloper());

            employees.Accept(new PaidTimeOffVisitor());
            employees.Accept(new IncomeVisitor());


        }
    }
}

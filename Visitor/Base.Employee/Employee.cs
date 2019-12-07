using Visitor.Abstractions.Visitor;

namespace Visitor.BaseEmployee
{
    public class Employee : IElement
    {
        public int PaidTimeOffDays { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int paidTimeOffDays, string name, double salary)
        {
            PaidTimeOffDays = paidTimeOffDays;
            Name = name;
            Salary = salary;
        }

        /// <summary>
        /// Allows adding new behaviors to existing class hierarchy without altering any existing code.
        /// Give the current object reference to be extended by the specified class.
        /// </summary>
        /// <param name="visitor">The object that you want to extend</param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

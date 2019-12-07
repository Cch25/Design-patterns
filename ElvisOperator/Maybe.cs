using System;

namespace ElvisOperator
{
    public class Maybe
    {
        public void MaybeCall(Person p)
        {
            string postalCode = p
                .If(IsEligible)
                .With(x => x.Address)
                .Do(CheckAdress)
                .Return(x => x.PostalCode, "Unknown");
            Console.WriteLine(postalCode);
        }

        private void CheckAdress(Address obj)
        {
            Console.WriteLine($"Checking person address: {obj.Number} {obj.PostalCode} {obj.Street}");
        }

        private bool IsEligible(Person arg)
        {
            return arg.Age >= 18;
        }
    }
}

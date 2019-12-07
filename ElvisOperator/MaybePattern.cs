namespace ElvisOperator
{
    public class MaybePattern
    {
        public void Maybe()
        {
            Person person = new Person()
            {
                Address = new Address()
                {
                    Number = 8,
                    PostalCode = "1231221",
                    Street = "Blvd"
                },
                Age = 28,
                Name = "CCh"
            };
            Maybe maybe = new Maybe();
            maybe.MaybeCall(person);
        }
    }
}

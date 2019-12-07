using System;

namespace ChainOfResponsibility.Mediator
{
    public class Infrastructure
    {
        public event EventHandler<Query> Queries;
        public void PerformQuery(object sender, Query query)
        {
            Queries?.Invoke(sender, query);
        }
    }
}

namespace DependecyInjection.Services
{
    public class ServiceA
    {
        ServiceB _serviceB;
        public ServiceA(ServiceB serviceB)
        {
            _serviceB = serviceB;
        }

        public void Print()
        {
            _serviceB.ShowMessage();
        }
    }
}

using Proxy.PropertyProxy;

namespace Proxy
{
    public class ProxyPattern
    {
        public void ProxyPropertyDemo()
        {
            TestPropertyProxy testPropertyProxy = new TestPropertyProxy();
            testPropertyProxy.Age = 28;
            testPropertyProxy.Age = 28;
        }
    }

    public class TestPropertyProxy
    {
        private readonly Property<int> age = new Property<int>();
        public int Age
        {
            get => age.Value;
            set => age.Value = value;
        }
        public void Test()
        {
            int test1 = new Property<int>(); //implicit operator T(Property<T> value);
            int test2 = age;//implicit operator T(T value);

        }
    }
}

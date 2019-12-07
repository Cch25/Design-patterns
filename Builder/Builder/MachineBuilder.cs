using Builder.Implementation.ConcreteImplementation;
using System;

namespace Builder.Builder
{
    public class MachineBuilder
    {
        private IParts machine { get; }
        public MachineBuilder(IParts machine)
        {
            this.machine = machine;
        }

        public MachineDetails Build(Action<IParts> components)
        {
            components(machine);
            return new MachineDetails(machine);
        }
       
    }
}

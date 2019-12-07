using Builder.Implementation.ConcreteImplementation;
using System;

namespace Builder.Builder
{
    public class MachineDetails
    {
        private readonly IParts machine;
        public IParts GetConfiguredMachine { get; }
        public MachineDetails(IParts machine)
        {
            this.machine = machine;
            GetConfiguredMachine = machine;
        }
        public virtual void CarConfiguration()
        {
            Parts parts = machine as Parts;
            string hasFrameAvailable = parts.hasFrame ? "has" : "doesn\'t have";
            string doors = parts.numberOfDoors > 0 ? $"it holds {parts.numberOfDoors} doors and" : "doesn\'t have any doors but";
            Console.WriteLine($"My {machine.GetType().Name} {hasFrameAvailable } mirrors, " +
                              $"{doors} it has {parts.numberOfWheels} wheels.");
        }
    }
}

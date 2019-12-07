using Builder.Builder;
using Builder.Implementation;

namespace Builder
{
    public class BuilderPattern
    {
        private readonly MachineBuilder _carBuilder;
        private readonly MachineBuilder _bycicleBuilder;

        public BuilderPattern()
        {
            _carBuilder = new MachineBuilder(new Car());
            _bycicleBuilder = new MachineBuilder(new Bycicle());
        }
        public void BuildMachine()
        {
            //Build a car and display me the results :)
            _carBuilder.Build(components =>
            {
                components.AddMirrors(true);
                components.AddWheels(4);
                components.AddDoors(2);
            }).CarConfiguration();


            //Build a bycicle with additional functionalities :)
            MachineDetails bycicleDetails = _bycicleBuilder.Build(c =>
              {
                  c.AddMirrors(false);
                  c.AddWheels(2);
              });
            bycicleDetails.CarConfiguration();
            Bycicle bycicle = bycicleDetails.GetConfiguredMachine as Bycicle;
            bycicle.AddAntiTheftDevice();
        }
    }
}

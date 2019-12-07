namespace Builder.Implementation.ConcreteImplementation
{
    public abstract class Parts : IParts
    {
        public int numberOfDoors { get; private set; }
        public int numberOfWheels { get; private set; }
        public bool hasFrame { get; private set; }

        void IParts.AddDoors(int doorsNo)
        {
            numberOfDoors = doorsNo;
        }

        void IParts.AddMirrors(bool hasFrame)
        {
            this.hasFrame = hasFrame;
        }

        void IParts.AddWheels(int wheelsNo)
        {
            numberOfWheels = wheelsNo;
        }
       
    }
}

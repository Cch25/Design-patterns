using ChainOfResponsibility.ChainOfResponsibility;

namespace ChainOfResponsibility.Mediator
{
    public class Query
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType { get; }
        public int Price { get; set; }
        public Query(int year, string name, VehicleType vehicleType, int price)
        {
            Year = year;
            Name = name;
            VehicleType = vehicleType;
            Price = price;
        }
    }
}

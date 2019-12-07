using ChainOfResponsibility.Mediator;
namespace ChainOfResponsibility.ChainOfResponsibility
{
    public enum VehicleType
    {
        BMW, AUDI, RollsRoyce, LAMBORGHINI, VOLKSWAGEN, DACIA
    }

    public class Car
    {
        #region [ Fields ]
        private string _name;
        private int _year;
        private VehicleType _vehicleType;
        private readonly int _price;
        private Infrastructure _infrastructure { get; set; }
        #endregion

        #region [ Properties ]
        public int Price
        {
            get
            {
                Query query = new Query(_year, _name, _vehicleType, _price);
                _infrastructure.PerformQuery(this, query);
                return query.Price;
            }
        }
        #endregion

        #region [ Constructor ]
        public Car(Infrastructure infrastructure, int year, string name, VehicleType vehicleType, int price)
        {
            _infrastructure = infrastructure;
            _year = year;
            _name = name;
            _vehicleType = vehicleType;
            _price = price;
        }
        #endregion
    }
}

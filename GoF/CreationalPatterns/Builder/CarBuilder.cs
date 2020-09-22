namespace GoF.CreationalPatterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private readonly Vehicle _vehicle;

        public CarBuilder()
        {
            _vehicle = new Vehicle("Civic");
        }

        public override VehicleBuilder AddWheels()
        {
            _vehicle["wheels"] = "4";

            return this;
        }

        public override VehicleBuilder AddEngine()
        {
            _vehicle["engine"] = "2500cc";

            return this;
        }

        public override VehicleBuilder AddPrice()
        {
            _vehicle["price"] = $"R$ 125.000,00";

            return this;
        }

        public override Vehicle Build()
        {
            return _vehicle;
        }
    }
}
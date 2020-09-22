namespace GoF.CreationalPatterns.Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        private readonly Vehicle _vehicle;

        public MotorCycleBuilder()
        {
            _vehicle = new Vehicle("Honda CBR 300");
        }

        public override VehicleBuilder AddWheels()
        {
            _vehicle["wheels"] = "2";

            return this;
        }

        public override VehicleBuilder AddEngine()
        {
            _vehicle["engine"] = "300cc";

            return this;
        }

        public override VehicleBuilder AddPrice()
        {
            _vehicle["price"] = $"R$ 12.000,00";

            return this;
        }

        public override Vehicle Build()
        {
            return _vehicle;
        }
    }
}
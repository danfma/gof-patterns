namespace GoF.CreationalPatterns.Builder
{
    public abstract class VehicleBuilder
    {
        public abstract VehicleBuilder AddWheels();
        public abstract VehicleBuilder AddEngine();
        public abstract VehicleBuilder AddPrice();
        public abstract Vehicle Build();
    }
}
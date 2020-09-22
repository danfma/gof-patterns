using System;

namespace GoF.CreationalPatterns.Builder
{
    public static class BuilderSample
    {
        public static void Run()
        {
            Print(Build(new CarBuilder()));
            Print(Build(new MotorCycleBuilder()));
        }

        private static Vehicle Build(VehicleBuilder builder)
        {
            return builder
                .AddEngine()
                .AddPrice()
                .AddWheels()
                .Build();
        }

        private static void Print(Vehicle vehicle)
        {
            Console.WriteLine("---");
            Console.WriteLine("Vehicle: {0}", vehicle.Name);
            Console.WriteLine("---");

            foreach (var (part, description) in vehicle.GetParts())
            {
                Console.WriteLine("{0}: {1}", part, description);
            }
            
            Console.WriteLine();
        }
    }
}
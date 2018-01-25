using System.Reflection;

namespace SampleSystem.Factories
{
    public class VehicleFactory
    {
        public static IVehicleFactory LoadFactory(int vehicleTypeId)
        {
            var className = "SampleSystem.Factories.TruckFactory"; //get class name from repository based on vehicle type
            var vehicleFactory = Assembly.GetExecutingAssembly().CreateInstance(className) as IVehicleFactory;
            return vehicleFactory;

        }
    }
}

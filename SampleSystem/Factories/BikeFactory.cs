using SampleSystem.Vehicles;
using SampleSystem.Vehicles.Bikes;

namespace SampleSystem.Factories
{
    public class BikeFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(int id)
        {
            //get details from database and return the model
            return new Bike();
        }
    }
}

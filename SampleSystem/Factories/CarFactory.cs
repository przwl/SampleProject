using SampleSystem.Vehicles;
using SampleSystem.Vehicles.Cars;

namespace SampleSystem.Factories
{
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(int id)
        {
            //get details from database and return the model
            return new Car();
        }
    }
}

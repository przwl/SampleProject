using SampleSystem.Vehicles;
using SampleSystem.Vehicles.Planes;

namespace SampleSystem.Factories
{
    public class PlaneFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(int id)
        {
            //get details from database and return the model
            return new Plane();
        }
    }
}

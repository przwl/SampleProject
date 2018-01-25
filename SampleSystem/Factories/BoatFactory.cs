using SampleSystem.Vehicles;
using SampleSystem.Vehicles.Boats;

namespace SampleSystem.Factories
{
    public class BoatFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(int id)
        {
            //get details from database and return the model
            return new Boat();
        }
    }
}

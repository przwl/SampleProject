using SampleSystem.Vehicles;
using SampleSystem.Vehicles.Trucks;

namespace SampleSystem.Factories
{
    public class TruckFactory : IVehicleFactory
    {

        /// <summary></summary>
        public IVehicle CreateVehicle(int id)
        {
            //get details from database and return the model
            return new Truck();
        }
    }
}

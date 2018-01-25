using SampleSystem.Vehicles;

namespace SampleSystem.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(int id);
    }
}

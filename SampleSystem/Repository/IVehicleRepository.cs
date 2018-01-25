using SampleSystem.Model;
using SampleSystem.Vehicles;
using System.Collections.Generic;

namespace SampleSystem.Repository
{
    public interface IVehicleRepository
    {
        string GetDetailsViewName(int vehicleId);
        IEnumerable<VehicleListModel> GetVehicleList(List<int> vehicleTypes);
        IVehicle GetVehicleDetail(int vehicleId, int vehicleTypeId);
        IEnumerable<VehicleType> GetVehicleTypes();
    }
}


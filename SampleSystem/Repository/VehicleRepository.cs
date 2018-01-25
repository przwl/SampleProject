using System.Collections.Generic;
using SampleSystem.Vehicles;
using SampleSystem.Factories;
using SampleSystem.Model;

namespace SampleSystem.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        public string GetDetailsViewName(int vehicleId)
        {
            //retrieve data from repository
            return "View name";
        }

        public IVehicle GetVehicleDetail(int vehicleId, int vehicleTypeId)
        {
            var vehicleFactory = VehicleFactory.LoadFactory(vehicleTypeId);
            var vehicleViewModel = vehicleFactory.CreateVehicle(vehicleId);
            return vehicleViewModel;
        }
        

        public IEnumerable<VehicleListModel> GetVehicleList(List<int> vehicleTypes)
        {
            //retrieve data from repository based on types
            return new List<VehicleListModel>(); 
        }

        public IEnumerable<VehicleType> GetVehicleTypes()
        {
            //retrieve data from repository
            return new List<VehicleType>();
        }
    }
}

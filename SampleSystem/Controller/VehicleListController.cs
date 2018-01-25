using SampleSystem.Repository;
using System.Collections.Generic;
using System.Web.Mvc;
namespace SampleSystem.Controller
{
    public class VehicleListController : System.Web.Mvc.Controller
    {
        IVehicleRepository _vehicleRepository;
        public VehicleListController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        /// <summary>
        /// Shows different vehicle types for which search can be performed
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            var listOfVehicleTypes = _vehicleRepository.GetVehicleTypes();
            return View(listOfVehicleTypes);
        }

        /// <summary>
        /// Gets the list of supplied vehicle type and displays it in a view
        /// </summary>
        /// <param name="vehicleType">Type of vehicle</param>
        /// <returns></returns>
        public ActionResult GetViewPerVehicleType(List<int> vehicleTypes)
        {
            var viewModel = _vehicleRepository.GetVehicleList(vehicleTypes);
            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        public ActionResult GetVehicleDetails(int vehicleId, int vehicleTypeId)
        {
            var viewModel = _vehicleRepository.GetVehicleDetail(vehicleId, vehicleTypeId);
            var viewName = _vehicleRepository.GetDetailsViewName(vehicleId);
            return View(viewName, viewModel);
           
        }


    }
}

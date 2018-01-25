namespace SampleSystem.Vehicles
{
    public interface IVehicle
    {
        int Id { get; set; }
        VehicleType VehicleType { get; set; }
        
    }
}
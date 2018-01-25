using System;

namespace SampleSystem.Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }


        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is on and running.");
        }


    }
}

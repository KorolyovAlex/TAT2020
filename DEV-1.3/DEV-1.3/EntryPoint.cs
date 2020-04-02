using System;
using System.Collections.Generic;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                List<Vehicle> vehiclePark = new List<Vehicle>();
                IVehicleFactory factory = new CarAutoTransmissionPetrolEngineFactory();

                vehiclePark.Add(factory.ProduceVehicle());
                vehiclePark.Add(factory.ProduceVehicle());

                factory = new CarMechanicTransmissionFactory();

                vehiclePark.Add(factory.ProduceVehicle());
                vehiclePark.Add(factory.ProduceVehicle());
                vehiclePark.Add(factory.ProduceVehicle());

                factory = new BusFactory();

                vehiclePark.Add(factory.ProduceVehicle());
                vehiclePark.Add(factory.ProduceVehicle());

                factory = new TruckMechanicTransmissionFactory();

                vehiclePark.Add(factory.ProduceVehicle());
                vehiclePark.Add(factory.ProduceVehicle());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class CarMechanicTransmissionFactory : IVehicleFactory
    {
        public Vehicle ProduceVehicle()
        {
            return new Car(new Transmission("Auto", 4, "GomelGaz"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class CarAutoTransmissionPetrolEngineFactory : IVehicleFactory
    {
        public Vehicle ProduceVehicle()
        {
            return new Car(new Engine(220, 2.5f, "Petrol", "234"), new Transmission("Auto", 4, "GomelGaz"));
        }
    }
}

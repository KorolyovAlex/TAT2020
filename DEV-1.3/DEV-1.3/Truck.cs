using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class Truck : Vehicle
    {

        public Truck(Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {

        }

        public new string GetInfo()
        {
            return $"Truck:\nNumber of seats: {_seatsNumber}\n{base.GetInfo()}";
        }
    }
}

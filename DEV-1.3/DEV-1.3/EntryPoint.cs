using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(82, new Engine(250, 12, "asv", "278"), new Chassis(12, "148", 2500), new Transmission("type", 123, "uau"), "AUFF");
            Console.WriteLine(bus.GetInfo());
        }
    }
}

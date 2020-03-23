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
                List<Vehicle> carPark = new List<Vehicle>();

                Bus bus = new Bus(82, new Engine(250, 10, "Gas", "AP76NU"), new Chassis(8, "ABCD", 4750), new Transmission("typeA", 5, "SomeFactoryA"), "MAZ 102D");
                carPark.Add(bus);
                Console.WriteLine(bus.GetInfo());

                Car car = new Car("Universal", new Engine(250, 6, "Electriacal", "14YUM9"), new Chassis(4, "DCBA", 2000), new Transmission("typeB", 6, "SomeFactoryB"), "Audi A6");
                carPark.Add(car);
                Console.WriteLine(car.GetInfo());

                Scooter scooter = new Scooter(110, new Engine(250, 5, "Petrol", "MLOI8"), new Chassis(2, "AD-CD", 400), new Transmission("typeC", 6, "SomeFactoryC"), "SUZUKI F");
                carPark.Add(scooter);
                Console.WriteLine(scooter.GetInfo());

                Truck truck = new Truck(1730, new Engine(250, 12, "Diesel", "1982-3AA"), new Chassis(6, "POJK", 7000), new Transmission("typeD", 4, "SomeFactoryD"), "JAC LE12");
                carPark.Add(truck);
                Console.WriteLine(truck.GetInfo());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
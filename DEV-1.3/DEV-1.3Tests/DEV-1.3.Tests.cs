using NUnit.Framework;
using System;

namespace DEV_1._3.Tests
{
    [TestFixture]
    public class StringValueValidatorTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        [TestCase("AB9DN7^")]
        public void ValidateStringValueTest(string value)
        {
            Assert.IsFalse(StringValueValidator.ValidateStringValue(value));
        }
    }

    [TestFixture]
    public class EngineTests
    {
        [TestCase((ushort)50, 2, "Universal", "ABCD")]
        [TestCase((ushort)50, 0.5f, "Universal", "ABCD")]
        [TestCase((ushort)50, 2, null, "ABCD")]
        [TestCase((ushort)50, 2, "Universal", null)]
        public void EngineConstructorThrowsArgumentException(ushort power, float capacity, string type, string serialNumber)
        {
            Assert.Throws<ArgumentException>(delegate { var engine = new Engine(power, capacity, type, serialNumber); });
        }
    }

    [TestFixture]
    public class ChassisTests
    {
        [TestCase(1, "MNB-76", (ushort)400)]
        [TestCase(4, null, (ushort)400)]
        [TestCase(4, "MNB-76", (ushort)76)]
        public void ChassisConstructorThrowsArgumentException(byte wheelsNumber, string serialNumber, ushort maxLoad)
        {
            Assert.Throws<ArgumentException>(delegate { var engine = new Chassis(wheelsNumber, serialNumber, maxLoad); });
        }
    }

    [TestFixture]
    public class TransmissionTests
    {
        [TestCase("", 6, "Suzuki")]
        [TestCase("type", 1, "BMW")]
        [TestCase("type", 6, "  ")]
        public void ChassisConstructorThrowsArgumentException(string type, byte gearsNumber, string manufacturer)
        {
            Assert.Throws<ArgumentException>(delegate { var transmission = new Transmission(type, gearsNumber, manufacturer); });
        }
    }

    [TestFixture]
    public class BusTests
    {
        Engine engine = new Engine(123, 123, "abc", "12-98");
        Transmission transmission = new Transmission("type", 6, "Hundai");
        Chassis chassis = new Chassis(6, "NBM71", 600);

        [TestCase(7)]
        public void BusConstructorThrowsArgumentException(byte seatsValue)
        {
            Assert.Throws<ArgumentException>(delegate { Bus bus = new Bus(seatsValue, engine, chassis, transmission, "Ikarus"); });
        }
    }

    [TestFixture]
    public class CarTests
    {
        Engine engine = new Engine(123, 123, "abc", "12-98");
        Transmission transmission = new Transmission("type", 6, "Hundai");
        Chassis chassis = new Chassis(6, "NBM71", 600);

        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        [TestCase("Au_di")]
        public void CarConstructorThrowsArgumentException(string carType)
        {
            Assert.Throws<ArgumentException>(delegate { var car = new Car(carType, engine, chassis, transmission, "Chevrolet Camaro"); });
        }
    }

    [TestFixture]
    public class ScooterTests
    {
        Engine engine = new Engine(123, 123, "abc", "12-98");
        Transmission transmission = new Transmission("type", 6, "Hundai");
        Chassis chassis = new Chassis(6, "NBM71", 600);

        [TestCase(35)]
        public void ScooterConstructorThrowsArgumentException(byte minSpeed)
        {
            Assert.Throws<ArgumentException>(delegate { var scooter = new Scooter(minSpeed, engine, chassis, transmission, "Scooter"); });
        }
    }

    [TestFixture]
    public class TruckTests
    {
        Engine engine = new Engine(123, 123, "abc", "12-98");
        Transmission transmission = new Transmission("type", 6, "Hundai");
        Chassis chassis = new Chassis(6, "NBM71", 600);

        [TestCase((ushort)450)]
        public void TruckConstructorThrowsArgumentException(ushort loadValue)
        {
            Assert.Throws<ArgumentException>(delegate { var truck = new Truck(loadValue, engine, chassis, transmission, "JVC"); });
        }
    }
}
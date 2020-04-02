using NUnit.Framework;
using System;

namespace DEV_1._4.Tests
{
    [TestFixture()]
    public class DroneTests
    {
        Drone drone = new Drone(new Point(10, 10, 10), 6);

        [TestCase(1)]
        [TestCase(162)]
        public void DroneSpeedOutOfRangeValueThrowsArgumentException(byte newSpeed)
        {       
            Assert.Throws<ArgumentException>(delegate { drone.Speed = newSpeed; });
        }

        [TestCase(110, 210, 210, 55)]
        public void GetFlyTimeTests(float pointX, float pointY, float pointZ, float expectedValue)
        {
            Assert.AreEqual(expectedValue, (float)drone.GetFlyTime(new Point(pointX, pointY, pointZ)));
        }

        [TestCase(110, 210, 210, 55)]
        public void GetFlyTimeDistanceOutOfRangeThrowsException(float pointX, float pointY, float pointZ, float expectedValue)
        {
            Assert.Throws<ArgumentException>(delegate { drone.GetFlyTime(new Point(pointX, pointY, pointZ)); });
        }
    }

    [TestFixture()]
    public class PlaneTests
    {
        Plane plane = new Plane(new Point(0, 0, 0));

        [TestCase(10, 20, 20, 0.15f)]
        public void GetFlyTimeTests(float pointX, float pointY, float pointZ, float expectedValue)
        {
            Assert.AreEqual(expectedValue, (float)plane.GetFlyTime(new Point(pointX, pointY, pointZ)));
        }
    }

    [TestFixture()]
    public class PointTests
    {
        [TestCase(-2.5f)]
        public void PointCoordinateXNegativeValueThrowsArgumentException(float xValue)
        {
            Assert.Throws<ArgumentException>(delegate { Point point = new Point(xValue, 0, 0); });
        }

        [TestCase(-2.5f)]
        public void PointCoordinateYNegativeValueThrowsArgumentException(float yValue)
        {
            Assert.Throws<ArgumentException>(delegate { Point point = new Point(0, yValue, 0); });
        }

        [TestCase(-2.5f)]
        public void PointCoordinateZNegativeValueThrowsArgumentException(float zValue)
        {
            Assert.Throws<ArgumentException>(delegate { Point point = new Point(0, 0, zValue); });
        }
    }
}
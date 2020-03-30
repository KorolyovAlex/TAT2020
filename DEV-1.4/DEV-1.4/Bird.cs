using System;

namespace DEV_1._4
{
    class Bird : IFlyable
    {
        private const int MAX_SPEED = 21;

        private readonly byte _speed;


        public Bird(Point location)
        {
            _speed = (byte) new Random().Next(MAX_SPEED);
            Location = location;
        }

        public Point Location { get; set; }

        public void FlyTo(Point newLocation)
        {
            Location = newLocation;
        }

        public double GetFlyTime(Point endPoint)
        {
            if (_speed == 0)
            {
                throw new Exception("Bird can't reach this location, it's speed is 0");
            }

            return Location.GetDistance(endPoint) / _speed;
        }
    }
}

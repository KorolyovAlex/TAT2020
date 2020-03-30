using System;

namespace DEV_1._4
{
    public class Bird : IFlyable
    {
        private const int MAX_SPEED = 21;

        private readonly byte _speed;

        public Bird(Point location)
        {
            _speed = (byte) new Random().Next(MAX_SPEED);
            Location = location;
        }

        public Point Location { get; set; }

        /// <summary>
        /// Changes the current location of bird
        /// </summary>
        /// <param name="newLocation">New location for bird</param>
        public void FlyTo(Point newLocation)
        {
            Location = newLocation;
        }

        /// <summary>
        /// Counts time for bird to get to argument location
        /// </summary>
        /// <param name="endPoint">The end location of flight</param>
        /// <returns>The flight time</returns>
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

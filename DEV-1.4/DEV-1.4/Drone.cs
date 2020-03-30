using System;

namespace DEV_1._4
{
    public class Drone : IFlyable
    {
        private const int MAX_FLIGHT_DISTANCE = 1000;
        private const double FLIGHT_TIME_WITHOUT_STOPS = 10f / 60;
        private const double STOP_TIME = 1f / 60;
        private const uint MIN_SPEED = 5;
        private const uint MAX_SPEED = 160;

        private byte _speed;

        public Drone(Point location, byte speed)
        {
            Location = location;
            Speed = speed;
        }

        public Point Location { get; set; }

        public byte Speed
        {
            get => _speed;
            set
            {
                if (value > MAX_SPEED || value < MIN_SPEED)
                {
                    throw new ArgumentException("Incorrect argument value for drone speed");
                }

                _speed = value;
            }
        }

        /// <summary>
        /// Changes the current location of drone
        /// </summary>
        /// <param name="newLocation">New location for drone</param>
        public void FlyTo(Point newLocation)
        {
            if(Location.GetDistance(newLocation) > MAX_FLIGHT_DISTANCE)
            {
                throw new ArgumentException("This location is unreachable for drone");
            }

            Location = newLocation;
        }

        /// <summary>
        /// Counts time for drone to get to argument location
        /// </summary>
        /// <param name="endPoint">The end location of flight</param>
        /// <returns>The flight time</returns>
        public double GetFlyTime(Point endPoint)
        {
            double distance = Location.GetDistance(endPoint);

            if (distance > MAX_FLIGHT_DISTANCE)
            {
                throw new ArgumentException("This location is unreachable for drone");
            }

            double flyTime = distance / _speed;

            return flyTime + flyTime / FLIGHT_TIME_WITHOUT_STOPS * STOP_TIME;
        }
    }
}

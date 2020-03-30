namespace DEV_1._4
{
    public class Plane : IFlyable
    {
        private const uint BASE_SPEED = 200;
        private const double ACCELERATION_DISTANCE = 10;
        private const uint ACCELERATION = 10;
        private const uint MAX_SPEED = 950;

        public Plane(Point location)
        {
            Location = location;
        }

        public Point Location { get; set; }

        /// <summary>
        /// Changes the current location of plane
        /// </summary>
        /// <param name="newLocation">New location for plane</param>
        public void FlyTo(Point newLocation)
        {
            Location = newLocation;
        }

        /// <summary>
        /// Counts time for plane to get to argument location
        /// </summary>
        /// <param name="endPoint">The end location of flight</param>
        /// <returns>The flight time</returns>
        public double GetFlyTime(Point endPoint)
        {
            uint currentSpeed = BASE_SPEED;
            double flyTime = 0;
            double remainingDistance = Location.GetDistance(endPoint);

            while(remainingDistance < ACCELERATION_DISTANCE && currentSpeed < MAX_SPEED)
            {
                flyTime += ACCELERATION_DISTANCE / currentSpeed;
                currentSpeed += ACCELERATION;
                remainingDistance -= ACCELERATION_DISTANCE;
            }

            flyTime += remainingDistance / currentSpeed;

            return flyTime;
        }
    }
}

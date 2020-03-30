namespace DEV_1._4
{
    class Plane : IFlyable
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

        public void FlyTo(Point newLocation)
        {
            Location = newLocation;
        }

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

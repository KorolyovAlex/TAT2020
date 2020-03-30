using System;

namespace DEV_1._4
{
    struct Point
    {
        private const int MIN_VALUE = 0;

        private float _coordinateX;
        private float _coordinateY;
        private float _coordinateZ;

        public Point(int x = 0, int y = 0, int z = 0)
        {
            _coordinateX = MIN_VALUE;
            _coordinateY = MIN_VALUE;
            _coordinateZ = MIN_VALUE;
            CoordinateX = x;
            CoordinateY = y;
            CoordinateZ = z;
        }

        public float CoordinateX
        {
            get => _coordinateX;
            private set
            {
                if(value < MIN_VALUE)
                {
                    throw new ArgumentException();
                }

                _coordinateX = value;
            }
        }

        public float CoordinateY
        {
            get => _coordinateY;
            private set
            {
                if (value < MIN_VALUE)
                {
                    throw new ArgumentException();
                }

                _coordinateY = value;
            }
        }

        public float CoordinateZ
        {
            get => _coordinateZ;
            private set
            {
                if (value < MIN_VALUE)
                {
                    throw new ArgumentException();
                }

                _coordinateZ = value;
            }
        }

        public double GetDistance(Point endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.CoordinateX - CoordinateX, 2)
                             + Math.Pow(endPoint.CoordinateY - CoordinateY, 2)
                             + Math.Pow(endPoint.CoordinateZ - CoordinateZ, 2));
        }
    }
}

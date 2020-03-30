using System;

namespace DEV_1._4
{
    public struct Point
    {
        const int MIN_VALUE = 0;

        float _coordinateX;
        float _coordinateY;
        float _coordinateZ;

        /// <summary>
        /// Constructor for Point struct
        /// </summary>
        /// <param name="x">Coordinate x value</param>
        /// <param name="y">Coordinate y value</param>
        /// <param name="z">Coordinate z value</param>
        public Point(float x = 0, float y = 0, float z = 0)
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

        /// <summary>
        /// Counts the distance to argument point
        /// </summary>
        /// <param name="endPoint">Second point to count distance</param>
        /// <returns>Distance between two points</returns>
        public double GetDistance(Point endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.CoordinateX - CoordinateX, 2)
                             + Math.Pow(endPoint.CoordinateY - CoordinateY, 2)
                             + Math.Pow(endPoint.CoordinateZ - CoordinateZ, 2));
        }
    }
}

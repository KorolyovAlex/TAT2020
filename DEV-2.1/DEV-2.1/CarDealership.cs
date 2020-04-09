using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_2._1
{
    class CarDealership
    {
        private static readonly CarDealership _instance = new CarDealership();

        public List<Car> Cars { get; }

        private CarDealership()
        {
            Cars = new List<Car>();
        }

        public static CarDealership Current => _instance;

        public void AddCars(Car car, uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cars.Add(car);
            }
        }

        public int GetCarCount()
        {
            return Cars.Count;
        }

        public double GetAveragePrice()
        {
            if (Cars.Count != 0)
            {
                return Cars.Select(x => x.Price).Average();
            }
            return 0;
        }

        public double GetAveragePriceByBrand(string brand)
        {
            if (Cars.Any(x => x.Brand.ToLower() == brand.ToLower()))
            {
                return Cars.Where(x => x.Brand.ToLower() == brand.ToLower()).Select(x => x.Price).Average();
            }
            throw new ArgumentException("There's no cars with such brand");
        }

        public int GetTypesCount()
        {
            return Cars.Select(x => x.Brand).Distinct().Count();
        }
    }
}

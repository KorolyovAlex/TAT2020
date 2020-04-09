using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_2._1
{
   /// <summary>
   /// Class of car dealership
   /// </summary>
    class CarDealership
    {
        /// <summary>
        /// List of cars in stock
        /// </summary>
        public List<Car> Cars { get; }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        private CarDealership()
        {
            Cars = new List<Car>();
        }

        /// <summary>
        /// Instance of the class that implements Singleton
        /// </summary>
        public static CarDealership Current { get; } = new CarDealership();

        /// <summary>
        /// Method that adds cars to the list
        /// </summary>
        /// <param name="car">Car to add</param>
        /// <param name="amount">Number of cars</param>
        public void AddCars(Car car, uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cars.Add(car);
            }
        }

        /// <summary>
        /// Method that counts the number of cars in stock
        /// </summary>
        /// <returns>Number of cars</returns>
        public int GetCarCount()
        {
            return Cars.Count;
        }

        /// <summary>
        /// Method that counts the average price of cars in stock
        /// </summary>
        /// <returns>The average price of cars</returns>
        public double GetAveragePrice()
        {
            if (Cars.Count != 0)
            {
                return Cars.Select(x => x.Price).Average();
            }
            return 0;
        }

        /// <summary>
        /// Method that counts the average price of certain brand cars
        /// </summary>
        /// <param name="brand">Brand of cars to count average price</param>
        /// <returns>The average price of certain brand cars</returns>
        public double GetAveragePriceByBrand(string brand)
        {
            if (Cars.Any(x => x.Brand.ToLower() == brand.ToLower()))
            {
                return Cars.Where(x => x.Brand.ToLower() == brand.ToLower()).Select(x => x.Price).Average();
            }
            throw new ArgumentException("There's no cars with such brand");
        }

        /// <summary>
        /// Method that count the number of brands of cars in stock
        /// </summary>
        /// <returns>The number of brands of cars</returns>
        public int GetTypesCount()
        {
            return Cars.Select(x => x.Brand).Distinct().Count();
        }
    }
}

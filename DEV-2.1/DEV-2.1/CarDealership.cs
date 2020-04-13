using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace DEV_2._1
{
   /// <summary>
   /// Class of car dealership
   /// </summary>
    class CarDealership
    {
        XDocument xDoc;
        /// <summary>
        /// Constructor of the class
        /// </summary>
        private CarDealership()
        {
            xDoc = new XDocument();
            xDoc = XDocument.Load("CarDB.xml");
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
            XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
            List<Car> carList = new List<Car>();

            using (FileStream fs = new FileStream("CarDB.xml", FileMode.OpenOrCreate))
            {
                carList = (List<Car>)serializer.Deserialize(fs);
            }

            for (int i = 0; i < amount; i++)
            {
                carList.Add(car);
            }

            using (FileStream fs = new FileStream("CarDb.xml", FileMode.Create))
            {
                serializer.Serialize(fs, carList);
            }

            xDoc = XDocument.Load("CarDB.xml");
        }

        /// <summary>
        /// Method that counts the number of cars in stock
        /// </summary>
        /// <returns>Number of cars</returns>
        public int GetCarCount()
        {
            return xDoc.Element("cars").Elements("car").Count();
        }

        /// <summary>
        /// Method that counts the average price of cars in stock
        /// </summary>
        /// <returns>The average price of cars</returns>
        public double GetAveragePrice()
        {
            if (xDoc.Element("cars").Elements("car").Count() != 0)
            {
                return xDoc.Element("cars").Elements("car").Select(x => Int32.Parse(x.Element("price").Value)).Average();
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
            if (xDoc.Element("cars").Elements("car").Any(x => x.Element("brand").Value.ToLower() == brand.ToLower()))
            {
                return xDoc.Element("cars").Elements("car").Where(x => x.Element("brand").Value.ToLower() == brand.ToLower()).Select(x => Int32.Parse(x.Element("price").Value)).Average();
            }
            throw new ArgumentException("There's no cars with such brand");
        }

        /// <summary>
        /// Method that count the number of brands of cars in stock
        /// </summary>
        /// <returns>The number of brands of cars</returns>
        public int GetTypesCount()
        {
            return xDoc.Element("cars").Elements("car").Select(x => x.Element("brand").Value).Distinct().Count();
        }
    }
}

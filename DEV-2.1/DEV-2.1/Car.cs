using System;

namespace DEV_2._1
{
    /// <summary>
    /// Class of car
    /// </summary>
    class Car
    {
        private int _price;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="price">Price of the car</param>
        /// <param name="brand">Brand of the car</param>
        /// <param name="model">Model of the car</param>
        public Car(int price, string brand, string model)
        {
            Price = price;
            Brand = brand;
            Model = model;
        }

        /// <summary>
        /// Price of the car
        /// </summary>
        public int Price
        {
            get => _price;
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Incorrect price!");
                    }
                    _price = value;
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter new car price: ");
                    Int32.TryParse(Console.ReadLine(), out int price);
                    Price = price;
                }
            }
        }

        /// <summary>
        /// Brand of the car
        /// </summary>
        public string Brand { get; }

        /// <summary>
        /// Model of the car
        /// </summary>
        public string Model { get; }
    }
}
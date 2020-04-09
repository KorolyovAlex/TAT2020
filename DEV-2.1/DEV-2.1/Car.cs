using System;

namespace DEV_2._1
{
    class Car
    {
        private int _price;

        public Car(int price, string brand, string model)
        {
            Price = price;
            Brand = brand;
            Model = model;
        }

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

        public string Brand { get; }
        public string Model { get; }
    }
}
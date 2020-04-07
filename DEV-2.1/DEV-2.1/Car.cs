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
                if(value > 0)
                {
                    _price = value;
                }
            }
        }

        public string Brand { get; }
        public string Model { get; }
    }
}
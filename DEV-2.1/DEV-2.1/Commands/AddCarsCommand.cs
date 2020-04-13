using System;

namespace DEV_2._1.Commands
{
    class AddCarsCommand : ICommand
    {
        private CarDealership _carDealership;

        public AddCarsCommand(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter car brand: ");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter car model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Enter car price: ");
                Int32.TryParse(Console.ReadLine(), out int price);

                Console.WriteLine("Enter number of cars: ");
                UInt32.TryParse(Console.ReadLine(), out uint amount);

                _carDealership.AddCars(new Car(price, brand, model), amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}

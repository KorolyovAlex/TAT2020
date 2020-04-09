using System;

namespace DEV_2._1.Commands
{
    class CountAllCommand : ICommand
    {
        private CarDealership _carDealership;

        public CountAllCommand(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        public void Execute()
        {
            Console.WriteLine($"{_carDealership.GetCarCount()} cars in stock");
        }
    }
}

using System;

namespace DEV_2._1.Commands
{
    /// <summary>
    /// Class of the average price type command
    /// </summary>
    class AveragePriceTypeCommand : ICommand
    {
        private CarDealership _carDealership;
        private readonly string _brand;

        public AveragePriceTypeCommand(CarDealership carDealership, string brand)
        {
            _carDealership = carDealership;
            _brand = brand;
        }

        public void Execute()
        {
            Console.WriteLine($"Average price of {_brand}: {_carDealership.GetAveragePriceByBrand(_brand)}$");
        }
    }
}

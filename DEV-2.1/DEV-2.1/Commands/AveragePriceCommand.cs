using System;

namespace DEV_2._1.Commands
{
    /// <summary>
    /// Class of the average price command
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        private CarDealership _carDealership;

        public AveragePriceCommand(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        public void Execute()
        {
            Console.WriteLine($"Average price of cars in stock: {_carDealership.GetAveragePrice()}$");
        }
    }
}

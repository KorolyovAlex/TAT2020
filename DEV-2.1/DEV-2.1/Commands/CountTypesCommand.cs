using System;

namespace DEV_2._1.Commands
{
    /// <summary>
    /// Class of the count types command
    /// </summary>
    class CountTypesCommand : ICommand
    {
        private CarDealership _carDealership;

        public CountTypesCommand(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        public void Execute()
        {
            Console.WriteLine($"{_carDealership.GetTypesCount()} brands of cars in stock");
        }
    }
}

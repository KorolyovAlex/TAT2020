using System;
using DEV_2._1.Commands;

namespace DEV_2._1.Invokers
{
    class CarManager
    {
        private const string COUNT_TYPES_COMMAND = "count types";
        private const string COUNT_ALL_COMMAND = "count all";
        private const string AVERAGE_PRICE_COMMAND = "average price";
        private const string EXIT_COMMAND = "exit";

        private CarDealership _carDealership;
        private ICommand _command;

        public CarManager(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        public void EnterCars()
        {
            while(true)
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

                    Console.WriteLine("Add more cars? (type no to exit): ");
                    if (Console.ReadLine().ToLower() == "no")
                    {
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Clear();
        }

        public void ChooseCommand()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter command:");
                    string command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case COUNT_TYPES_COMMAND:
                            {
                                SetCommand(new CountTypesCommand(_carDealership));
                                ExecuteCommand();
                                break;
                            }
                        case COUNT_ALL_COMMAND:
                            {
                                SetCommand(new CountAllCommand(_carDealership));
                                ExecuteCommand();
                                break;
                            }
                        case AVERAGE_PRICE_COMMAND:
                            {
                                SetCommand(new AveragePriceCommand(_carDealership));
                                ExecuteCommand();
                                break;
                            }
                        case EXIT_COMMAND:
                            {
                                SetCommand(new ExitCommand());
                                ExecuteCommand();
                                break;
                            }
                        default:
                            {
                                if (command.StartsWith(AVERAGE_PRICE_COMMAND))
                                {
                                    string brand = command.Remove(0, AVERAGE_PRICE_COMMAND.Length + 1);
                                    SetCommand(new AveragePriceTypeCommand(_carDealership, brand));
                                    ExecuteCommand();
                                    break;
                                }
                                throw new ArgumentException("Incorrect command!");
                            }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void SetCommand(ICommand newCommand)
        {
            _command = newCommand;
        }

        private void ExecuteCommand()
        {
            _command?.Execute();
        }
    }
}

using System;
using DEV_2._1.Commands;

namespace DEV_2._1.Invokers
{
    /// <summary>
    /// Class of the invoker for commands
    /// </summary>
    class CarManager
    {
        private const string COUNT_TYPES_COMMAND = "count types";
        private const string COUNT_ALL_COMMAND = "count all";
        private const string AVERAGE_PRICE_COMMAND = "average price";
        private const string EXIT_COMMAND = "exit";

        private CarDealership _carDealership;
        private ICommand _command;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="carDealership">Reciever</param>
        public CarManager(CarDealership carDealership)
        {
            _carDealership = carDealership;
        }

        /// <summary>
        /// Method that allows user to add cars to CarDealership Cars list
        /// </summary>
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

        /// <summary>
        /// Method that allows user to enter commands
        /// </summary>
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

        /// <summary>
        /// Method that sets new command
        /// </summary>
        /// <param name="newCommand"></param>
        private void SetCommand(ICommand newCommand)
        {
            _command = newCommand;
        }

        /// <summary>
        /// Method that executes the command
        /// </summary>
        private void ExecuteCommand()
        {
            _command?.Execute();
        }
    }
}

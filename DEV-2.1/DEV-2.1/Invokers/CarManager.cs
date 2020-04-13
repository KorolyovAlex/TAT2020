using System;
using DEV_2._1.Commands;

namespace DEV_2._1.Invokers
{
    /// <summary>
    /// Class of the invoker for commands
    /// </summary>
    class CarManager
    {
        private const string ADD_CARS_COMMAND = "add cars";
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
                        case ADD_CARS_COMMAND:
                            {
                                SetCommand(new AddCarsCommand(_carDealership));
                                ExecuteCommand();
                                Console.Clear();
                                break;
                            }
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

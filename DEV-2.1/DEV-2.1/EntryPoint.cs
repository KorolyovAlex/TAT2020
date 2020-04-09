using DEV_2._1.Invokers;

namespace DEV_2._1
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    class EntryPoint
    {
        static void Main()
        {
            var carDealership = CarDealership.Current;
            var manager = new CarManager(carDealership);
            manager.EnterCars();
            manager.ChooseCommand();
        }
    }
}

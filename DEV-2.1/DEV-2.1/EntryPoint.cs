using DEV_2._1.Invokers;

namespace DEV_2._1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var carDealership = CarDealership.Current;
            var manager = new CarManager(carDealership);
            manager.EnterCars();
            manager.ChooseCommand();
        }
    }
}

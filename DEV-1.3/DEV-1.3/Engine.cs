namespace DEV_1._3
{
    class Engine
    {
        public int Power { get; private set; }
        public double Capacity { get; private set; }
        public string Type { get; private set; }
        public string SerialNumber { get; private set; }

        public Engine(int power, double capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }
    }
}

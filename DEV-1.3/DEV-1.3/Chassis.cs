namespace DEV_1._3
{
    class Chassis
    {
        public int WheelsNumber { get; private set; }
        public string SerialNumber { get; private set; }
        public int MaxLoad { get; private set; }

        public Chassis(int wheelsNumber, string serialNumber, int maxLoad)
        {
            WheelsNumber = wheelsNumber;
            SerialNumber = serialNumber;
            MaxLoad = MaxLoad;
        }
    }
}

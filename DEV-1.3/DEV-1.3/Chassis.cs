namespace DEV_1._3
{
    class Chassis
    {
        public byte WheelsNumber { get; private set; }
        public string SerialNumber { get; private set; }
        public ushort MaxLoad { get; private set; }

        public Chassis(byte wheelsNumber, string serialNumber, ushort maxLoad)
        {
            WheelsNumber = wheelsNumber;
            SerialNumber = serialNumber;
            MaxLoad = MaxLoad;
        }

        public string GetInfo()
        {
            return $"Chassis:\nSerial number: {SerialNumber}\nNumber of wheels: {WheelsNumber}\nMaximum load: {MaxLoad}\n";
        }
    }
}

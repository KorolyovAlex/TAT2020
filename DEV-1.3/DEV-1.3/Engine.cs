namespace DEV_1._3
{
    class Engine
    {
        public ushort Power { get; private set; }
        public float Capacity { get; private set; }
        public string Type { get; private set; }
        public string SerialNumber { get; private set; }

        public Engine(ushort power, float capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            return $"Engine:\nSerial number: {SerialNumber}\nType: {Type}\nPower: {Power}\nCapacity: {Capacity}\n";
        }
    }
}

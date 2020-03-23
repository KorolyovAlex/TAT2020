namespace DEV_1._3
{
    class Transmission
    {
        public string Type { get; private set; }
        public byte GearsNumber { get; private set; }
        public string Manufacturer { get; private set; }

        public Transmission(string type, byte gearsNumber, string manufacturer)
        {
            Type = type;
            GearsNumber = gearsNumber;
            Manufacturer = manufacturer;
        }

        public string GetInfo()
        {
            return $"Transmission:\nType: {Type}\nNumber of gears: {GearsNumber}\nManufacturer: {Manufacturer}\n";
        }
    }
}

namespace DEV_1._3
{
    class Transmission
    {
        public string Type { get; private set; }
        public int GearsNumber { get; private set; }
        public string Producer { get; private set; }

        public Transmission(string type, int gearsNumber, string producer)
        {
            Type = type;
            GearsNumber = gearsNumber;
            Producer = producer;
        }
    }
}

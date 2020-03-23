namespace DEV_1._3
{
    class Car : Vehicle
    {
        private string _type;

        public Car(string type, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            Type = type;
        }

        public string Type
        {
            get => _type;
            private set
            {
                ValidateStringValue(value);

                _type = value;
            }
        }

        public new string GetInfo()
        {
            return $"Car:\nType: {Type}\n{base.GetInfo()}";
        }
    }
}
using System;

namespace DEV_1._3
{
    public class Car : Vehicle
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
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for car type");
                }

                _type = value;
            }
        }

        public new string GetInfo()
        {
            return $"Car:\nType: {Type}\n{base.GetInfo()}";
        }
    }
}
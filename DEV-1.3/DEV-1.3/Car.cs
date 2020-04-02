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
        
        public Car(Engine engine, Transmission transmission)
        {
            this.Engine = engine;
            this.Transmission = transmission;
        }

        public Car(Transmission transmission)
        {
            this.Transmission = transmission;
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

        public override string GetInfo()
        {
            return $"Car:\nType: {Type}\n{base.GetInfo()}";
        }
    }
}
using System;

namespace DEV_1._3
{
    public abstract class Vehicle
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _name;

        public Vehicle() { }
        protected Vehicle(Engine engine, Chassis chassis, Transmission transmission, string name)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Name = name;
        }

        public Engine Engine
        {
            get => _engine;
            set
            {
                _engine = value ?? throw new ArgumentNullException("The engine argument has no reference");
            }
        }

        public Chassis Chassis
        {
            get => _chassis;
            set
            {
                _chassis = value ?? throw new ArgumentNullException("The chassis argument has no reference");
            }
        }

        public Transmission Transmission
        {
            get => _transmission;
            set
            {
                _transmission = value ?? throw new ArgumentNullException("The transmission value has no reference");
            }
        }

        public string Name
        {
            get => _name;
            protected set
            {
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for vehicle name");
                }

                _name = value;
            }
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}\n\n{Engine.GetInfo()}\n{Transmission.GetInfo()}\n{Chassis.GetInfo()}";
        }

    }
}
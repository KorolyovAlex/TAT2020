using System;
using System.Linq;

namespace DEV_1._3
{
    abstract class Vehicle
    {
        private const string VALID_CHARACTERS = "1234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz-. ";

        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _name;

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
            get
            {
                return _name;
            }
            protected set
            {
                ValidateStringValue(value);

                _name = value;
            }
        }

        protected void ValidateStringValue(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid string argument");
            }

            foreach (char character in value)
            {
                if (!VALID_CHARACTERS.Contains(character))
                {
                    throw new FormatException($"Argument {value} contains invalid character {character}");
                }
            }
        }

        protected string GetInfo()
        {
            return $"Name: {Name}\n\n{Engine.GetInfo()}\n{Transmission.GetInfo()}\n{Chassis.GetInfo()}";
        }

    }
}
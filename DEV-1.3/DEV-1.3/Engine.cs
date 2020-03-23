using System;
using System.Linq;

namespace DEV_1._3
{
    class Engine
    {
        private const float MIN_CAPACITY = 1.0f;
        private const ushort MIN_POWER = 100;
        private const string VALID_CHARACTERS = "1234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz-";

        private ushort _power;
        private float _capacity;
        private string _type;
        private string _serialNumber;

        public Engine(ushort power, float capacity, string type, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }

        public ushort Power
        {
            get => _power;
            private set
            {
                if(value < MIN_POWER)
                {
                    throw new ArgumentException();
                }

                _power = value;
            }
        }

        public float Capacity
        {
            get => _capacity;
            private set
            {
                if(value < MIN_CAPACITY)
                {
                    throw new ArgumentException();
                }

                _capacity = value;
            }
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

        public string SerialNumber
        {
            get => _serialNumber;
            private set
            {
                ValidateStringValue(value);

                _serialNumber = value;
            }
        }

        public string GetInfo()
        {
            return $"Engine:\nSerial number: {SerialNumber}\nType: {Type}\nPower: {Power}\nCapacity: {Capacity}\n";
        }

        private void ValidateStringValue(string value)
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
    }
}
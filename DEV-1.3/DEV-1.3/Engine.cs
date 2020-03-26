using System;

namespace DEV_1._3
{
    class Engine
    {
        private const float MIN_CAPACITY = 1.0f;
        private const ushort MIN_POWER = 100;

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
                    throw new ArgumentException($"Engine power value can't be less than {MIN_POWER}");
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
                    throw new ArgumentException($"Engine capacity value can't be less than {MIN_CAPACITY}");
                }

                _capacity = value;
            }
        }

        public string Type
        {
            get => _type;
            private set
            {
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for engine type");
                }

                _type = value;
            }
        }

        public string SerialNumber
        {
            get => _serialNumber;
            private set
            {
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for engine serial number");
                }

                _serialNumber = value;
            }
        }

        public string GetInfo()
        {
            return $"Engine:\nSerial number: {SerialNumber}\nType: {Type}\nPower: {Power}\nCapacity: {Capacity}\n";
        }
    }
}
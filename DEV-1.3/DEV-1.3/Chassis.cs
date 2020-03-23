using System;
using System.Linq;

namespace DEV_1._3
{
    class Chassis
    {
        private const byte MIN_WHEELS_NUMBER = 2;
        private const ushort MIN_LOAD = 100;
        private const string VALID_CHARACTERS = "1234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz-";

        private byte _wheelsNumber;
        private string _serialNumber;
        private ushort _maxLoad;

        public Chassis(byte wheelsNumber, string serialNumber, ushort maxLoad)
        {
            WheelsNumber = wheelsNumber;
            SerialNumber = serialNumber;
            MaxLoad = maxLoad;
        }

        public byte WheelsNumber
        {
            get => _wheelsNumber;
            private set
            {
                if(value < MIN_WHEELS_NUMBER)
                {
                    throw new ArgumentException($"Vehicle can't have less than {MIN_WHEELS_NUMBER} wheels");
                }
                _wheelsNumber = value;
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

        public ushort MaxLoad
        {
            get => _maxLoad;
            private set
            {
                if(value < MIN_LOAD)
                {
                    throw new ArgumentException($"Max load value can't be less than {MIN_LOAD}");
                }
                _maxLoad = value;
            }
        }

        public string GetInfo()
        {
            return $"Chassis:\nSerial number: {SerialNumber}\nNumber of wheels: {WheelsNumber}\nMaximum load: {MaxLoad}\n";
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
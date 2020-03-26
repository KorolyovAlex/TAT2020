using System;

namespace DEV_1._3
{
    public class Chassis
    {
        private const byte MIN_WHEELS_NUMBER = 2;
        private const ushort MIN_LOAD = 100;

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
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for chassis serial number");
                }

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
    }
}
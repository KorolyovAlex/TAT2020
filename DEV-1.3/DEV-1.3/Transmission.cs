using System;

namespace DEV_1._3
{
    public class Transmission
    {
        private const byte MIN_GEARS_NUMBER = 4;

        private string _type;
        private byte _gearsNumber;
        private string _manufacturer;

        public Transmission(string type, byte gearsNumber, string manufacturer)
        {
            Type = type;
            GearsNumber = gearsNumber;
            Manufacturer = manufacturer;
        }

        public string Type
        {
            get => _type;
            private set
            {
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for transmission type");
                }

                _type = value;
            }
        }

        public byte GearsNumber
        {
            get => _gearsNumber;
            private set
            {
                if(value < MIN_GEARS_NUMBER)
                {
                    throw new ArgumentException($"The gears number can't be less than {MIN_GEARS_NUMBER}");
                }

                _gearsNumber = value;
            }
        }

        public string Manufacturer
        {
            get => _manufacturer;
            private set
            {
                if (!StringValueValidator.ValidateStringValue(value))
                {
                    throw new ArgumentException("Invalid string value for transmission manufacturer");
                }

                _manufacturer = value;
            }
        }

        public string GetInfo()
        {
            return $"Transmission:\nType: {Type}\nNumber of gears: {GearsNumber}\nManufacturer: {Manufacturer}\n";
        }
    }
}
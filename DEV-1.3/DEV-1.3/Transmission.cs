using System;
using System.Linq;

namespace DEV_1._3
{
    class Transmission
    {
        private const byte MIN_GEARS_NUMBER = 4;
        private const string VALID_CHARACTERS = "1234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz-";

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
                ValidateStringValue(value);

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
                ValidateStringValue(value);

                _manufacturer = value;
            }
        }

        public string GetInfo()
        {
            return $"Transmission:\nType: {Type}\nNumber of gears: {GearsNumber}\nManufacturer: {Manufacturer}\n";
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
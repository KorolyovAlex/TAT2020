using System;

namespace CW_4
{
    static class ConverterCreator
    {
        public static Converter GetConverter(string convertCommand)
        {
            if(!Enum.TryParse(convertCommand, true, out Commands command))
            {
                throw new ArgumentException("There's no such command");
            }

            switch (command)
            {
                case Commands.MF:
                    {
                        return new LengthConverter();
                    }
                case Commands.FM:
                    {
                        return new LengthConverter();
                    }
                case Commands.FC:
                    {
                        return new TemperatureConverter();
                    }
                case Commands.CF:
                    {
                        return new TemperatureConverter();
                    }
                default:
                    {
                        throw new Exception("Can't create converter");
                    }
            }
        }
    }
}

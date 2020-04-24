using System;

namespace CW_4
{
    class LengthConverter : Converter
    {
        private const double FOOTS_IN_ONE_METER = 3.2808;
        private const double METERS_IN_ONE_FOOT = 0.3048;
        private const int SYMBOLS_AFTER_DECIMAL_POINT = 4;

        public override double Convert(double value, string convertCommand)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid value for length param ({value})");
            }

            if(!Enum.TryParse(convertCommand, true, out Commands command))
            {
                throw new ArgumentException("There's no such command");
            }

            switch(command)
            {
                case Commands.FM:
                    {
                        return ConvertFootsToMeters(value);
                    }
                case Commands.MF:
                    {
                        return ConvertMetersToFoots(value);
                    }
                default:
                    {
                        throw new ArgumentException("Invalid command");
                    }
            }
        }

        private double ConvertFootsToMeters(double value)
        {
            return Math.Round(value * METERS_IN_ONE_FOOT, SYMBOLS_AFTER_DECIMAL_POINT);
        }

        private double ConvertMetersToFoots(double value)
        {
            return Math.Round(value * FOOTS_IN_ONE_METER, SYMBOLS_AFTER_DECIMAL_POINT);
        }
    }
}

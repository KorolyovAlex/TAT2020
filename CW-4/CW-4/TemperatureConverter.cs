using System;

namespace CW_4
{
    class TemperatureConverter : Converter
    {
        private const int F_TO_C_CONST = 32;
        private const double FAHRENHEIT_TO_CELSIUS = 5 / 9;
        private const int SYMBOLS_AFTER_DECIMAL_POINT = 2;

        public override double Convert(double value, string convertCommand)
        {
            Enum.TryParse(convertCommand, true, out Commands command);
            switch (command)
            {
                case Commands.CF:
                    {
                        return ConvertCelsiusToFahrenheit(value);
                    }
                case Commands.FC:
                    {
                        return ConvertFahrenheitToCelsius(value);
                    }
                default:
                    {
                        throw new Exception("Invalid command");
                    }
            }
        }

        private double ConvertFahrenheitToCelsius(double value)
        {
            return Math.Round((value - F_TO_C_CONST) * FAHRENHEIT_TO_CELSIUS, SYMBOLS_AFTER_DECIMAL_POINT);
        }

        private double ConvertCelsiusToFahrenheit(double value)
        {
            return Math.Round(value / FAHRENHEIT_TO_CELSIUS, SYMBOLS_AFTER_DECIMAL_POINT);
        }
    }
}
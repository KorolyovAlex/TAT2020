using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1._2
{
    /// <summary>
    /// Converts decimal numbers to another numeral system
    /// </summary>
    public class NumeralSystemConverter
    {
        private const byte minBaseValue = 2;
        private const byte maxBaseValue = 20;
        
        private readonly Dictionary<string, string> _convertKeys = new Dictionary<string, string>()
        {
            {"0", "0"},
            {"1", "1"},
            {"2", "2"},
            {"3", "3"},
            {"4", "4"},
            {"5", "5"},
            {"6", "6"},
            {"7", "7"},
            {"8", "8"},
            {"9", "9"},
            {"10", "A"},
            {"11", "B"},
            {"12", "C"},
            {"13", "D"},
            {"14", "E"},
            {"15", "F"},
            {"16", "G"},
            {"17", "H"},
            {"18", "I"},
            {"19", "J"}
        };

        /// <summary>
        /// Convert given number to new numeral system with given base
        /// </summary>
        /// <param name="number">The number which will be converted</param>
        /// <param name="systemBase">The base of the new numeral system</param>
        /// <returns></returns>
        public string ConvertNumber(uint number, uint systemBase)
        {
            ValidateBaseValue(systemBase);

            StringBuilder result = new StringBuilder();
            uint remaindedValue = number;

            while (remaindedValue >= systemBase)
            {
                result.Insert(0, _convertKeys[(remaindedValue % systemBase).ToString()]);
                remaindedValue /= systemBase;
            }
            result.Insert(0, _convertKeys[remaindedValue.ToString()]);

            return result.ToString();
        }

        /// <summary>
        /// Validating value of new system base to correspond the conditions
        /// </summary>
        /// <param name="systemBase"></param>
        private void ValidateBaseValue(uint systemBase)
        {
            if (systemBase < minBaseValue || systemBase > maxBaseValue)
            {
                throw new ArgumentException($"Numeral system base value {systemBase} out of range ({minBaseValue}-{maxBaseValue})");
            }
        }
    }
}


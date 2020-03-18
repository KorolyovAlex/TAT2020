using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1._2
{
    public class NumeralSystemConverter
    {
        private readonly Dictionary<string, string> _convertKeys = new Dictionary<string, string>()
        {
            {"0", "0" },
            {"1", "1" },
            {"2", "2" },
            {"3", "3" },
            {"4", "4" },
            {"5", "5" },
            {"6", "6" },
            {"7", "7" },
            {"8", "8" },
            {"9", "9" },
            {"10", "A" },
            {"11", "B" },
            {"12", "C" },
            {"13", "D" },
            {"14", "E" },
            {"15", "F" },
            {"16", "G" },
            {"17", "H" },
            {"18", "I" },
            {"19", "J" }
        };

        public string ConvertNumber(uint number, uint systemBase)
        {
            ValidateValue(systemBase);
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

        private void ValidateValue(uint systemBase)
        {
            if (systemBase < 3 || systemBase > 20)
            {
                throw new ArgumentException($"Numeral system base value {systemBase} out of range (3-20)");
            }
        }
    }
}


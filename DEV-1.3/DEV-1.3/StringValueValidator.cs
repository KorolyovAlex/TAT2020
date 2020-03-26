using System;
using System.Linq;

namespace DEV_1._3
{
    static class StringValueValidator
    {
        private const string VALID_CHARACTERS = "1234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz- ";

        public static bool ValidateStringValue(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return false;  
            }

            foreach (char character in value)
            {
                if (!VALID_CHARACTERS.Contains(character))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

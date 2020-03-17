using System;

namespace DEV_1
{
    /// <summary>
    /// Analyzer of entered String
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// Returns the length of the longest sequence of similar symbols in given string
        /// </summary>
        /// <param name="inputString"> Inputed string </param>
        public int CountSimilarSymbolsSequence(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return 0;
            }

            return CountSequence(inputString, (x, y) => x == y);
        }

        /// <summary>
        /// Returns the length of the longest sequence of different symbols in given string
        /// </summary>
        /// <param name="inputString"> Inputed string </param>
        public int CountDifferentSymbolsSequence(string inputString)
        {
            if(String.IsNullOrEmpty(inputString))
            {
                return 0;
            }

            return CountSequence(inputString, (x, y) => x != y);
        }

        /// <summary>
        /// Counts the length of the longest sequence of symbols according to condition func
        /// </summary>
        /// <param name="inputString"> Inputed string </param>
        /// <param name="func"> Compare condition </param>
        /// <returns> The length of the longest sequence of symbols </returns>
        private int CountSequence(string inputString, Func<char, char, bool> func)
        {
            int maxLength = 1, counter = 1;
            inputString = inputString.ToLower();

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (func(inputString[i], inputString[i + 1]))
                {
                    counter++;
                }
                else
                {
                    if (counter > maxLength)
                    {
                        maxLength = counter;
                    }
                    counter = 1;
                }
            }

            //In case of longest sequence in the end of string
            if (counter > maxLength) 
            {
                maxLength = counter;
            }

            return maxLength;
        }
    }
}

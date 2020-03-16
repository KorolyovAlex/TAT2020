using System;

namespace DEV_1
{
    /// <summary>
    /// Analyzer of entred line
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// Checking is line correct and gives count condition
        /// </summary>
        /// <param name="str"> Line that was given in command line </param>
        /// <returns> The length of the longest sequence of similar symbols </returns>
        public int CountSimilarSymbolsSequence(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }

            return CountSequence(str, (x, y) => x == y);
        }

        /// <summary>
        /// Checking is line correct and gives count condition
        /// </summary>
        /// <param name="str"> Line that was given in command line </param>
        /// <returns> The length of the longest sequence of different symbols </returns>
        public int CountDifferentSymbolsSequence(string str)
        {
            if(String.IsNullOrEmpty(str))
            {
                return 0;
            }

            return CountSequence(str, (x, y) => x != y);
        }

        /// <summary>
        /// Counts the length of the longest sequence of similar symbols
        /// </summary>
        /// <param name="str"> Line that was given in command line </param>
        /// <param name="func"> Compare condition </param>
        /// <returns> The length of the longest sequence of symbols according to condition func </returns>
        private int CountSequence(string str, Func<char, char, bool> func)
        {
            int maxLength = 1, counter = 1;
            str = str.ToLower();

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (func(str[i], str[i + 1]))
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

            //In case of longest sequence in the end of line
            if (counter > maxLength) 
            {
                maxLength = counter;
            }

            return maxLength;
        }
    }
}

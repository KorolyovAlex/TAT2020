using System;

namespace DEV_1
{
    /// <summary>
    /// Analyzer of entered String
    /// </summary>
    public class StringAnalyzer
    {
        /// <summary>
        /// Counts the length of the longest sequence of similar symbols in given string
        /// </summary>
        /// <param name="textLine"> String to count longest sequence </param>
        /// <returns> The length of the longest sequence of similar symbols </returns>
        public int CountSimilarSymbolsSequence(string textLine)
        {
            if (String.IsNullOrEmpty(textLine))
            {
                return 0;
            }

            return CountSequence(textLine, (x, y) => x == y);
        }

        /// <summary>
        /// Counts the length of the longest sequence of different symbols in given string
        /// </summary>
        /// <param name="textLine"> String to count longest sequence </param>
        /// <returns> The length of the longest sequence of different symbols </returns>
        public int CountDifferentSymbolsSequence(string textLine)
        {
            if(String.IsNullOrEmpty(textLine))
            {
                return 0;
            }

            return CountSequence(textLine, (x, y) => x != y);
        }

        /// <summary>
        /// Counts the length of the longest sequence of similar symbols
        /// </summary>
        /// <param name="textLine"> String to count longest sequence </param>
        /// <param name="func"> Compare condition </param>
        /// <returns> The length of the longest sequence of symbols according to condition func </returns>
        private int CountSequence(string textLine, Func<char, char, bool> func)
        {
            int maxLength = 1, counter = 1;
            textLine = textLine.ToLower();

            for (int i = 0; i < textLine.Length - 1; i++)
            {
                if (func(textLine[i], textLine[i + 1]))
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

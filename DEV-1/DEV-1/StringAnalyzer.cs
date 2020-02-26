namespace DEV_1
{
    /// <summary>
    /// Analyzer of entred line
    /// </summary>
    class StringAnalyzer
    {
        /// <summary>
        /// Counts the length of the longest sequence of similar symbols
        /// </summary>
        /// <param name="str"> Line that was entered in console </param>
        /// <returns> The length of the longest sequence of similar symbols </returns>
        public int CountSequence(string str)
        {
            int maxLength = 1, counter = 1;
            str.ToLower();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
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
            return maxLength;
        }
    }
}

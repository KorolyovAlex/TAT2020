using System;

namespace DEV_1
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"> Command line arguments </param>
        static void Main(string[] args)
        {
            try
            {
                foreach (string line in args)
                {
                    Console.WriteLine($"Your line: {line}");
                    StringAnalyzer analyzer = new StringAnalyzer();
                    Console.WriteLine($"{analyzer.CountSimilarSymbolsSequence(line)} similar symbol(s)");
                    Console.WriteLine($"{analyzer.CountDifferentSymbolsSequence(line)} different symbol(s)");

                    Console.Write("\n");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

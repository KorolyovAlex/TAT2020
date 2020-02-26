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
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Your line: {args[i]}");
                    StringAnalyzer analyzer = new StringAnalyzer();
                    Console.WriteLine(analyzer.CountSimilarSymbolsSequence(args[i]));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

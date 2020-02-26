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
        static void Main()
        {
            Console.WriteLine("Enter your line:");
            string line = Console.ReadLine();
            StringAnalyzer analyzer = new StringAnalyzer();
            Console.WriteLine(analyzer.CountSequence(line));
        }
    }
}

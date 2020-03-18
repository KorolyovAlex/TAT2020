using System;

namespace DEV_1._2
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            var converter = new NumeralSystemConverter();

            for (int i = 0; i < args.Length - 1; i += 2)
            {
                try
                {
                    if (!UInt32.TryParse(args[i], out uint value) || !UInt32.TryParse(args[i + 1], out uint systemBase))
                    {
                        throw new FormatException($"Incorrect value format of number ({args[i]}) or system's base ({args[i + 1]})");
                    }

                    Console.WriteLine($"Convertation of number {value} to numeral system with base {systemBase}:" +
                                      $" {converter.ConvertNumber(value, systemBase)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}

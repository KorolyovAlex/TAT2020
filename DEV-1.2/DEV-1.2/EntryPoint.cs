using System;

namespace DEV_1._2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var converter = new NumeralSystemConverter();
            uint value, systemBase;

            for (int i = 0; i < args.Length - 1; i += 2)
            {
                try
                {
                    value = UInt32.Parse(args[i]);
                    systemBase = UInt32.Parse(args[i + 1]);

                    Console.WriteLine($"Convertation of number {value} to numeral system with base {systemBase}:" +
                                      $" {converter.ConvertNumber(value, systemBase)}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}

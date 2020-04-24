using System;

namespace CW_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentException("There's not enough arguments in command line");
                }
                if (!Double.TryParse(args[0], out double value))
                {
                    throw new ArgumentException($"Can't convert {args[0]} to double");
                }

                Converter converter = ConverterCreator.GetConverter(args[1]);

                Console.WriteLine(converter.Convert(value, args[1]));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

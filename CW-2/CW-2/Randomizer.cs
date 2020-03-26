using System;

namespace CW_2
{
    static class Randomizer
    {
        private const int RAND_MIN_VALUE = 48;
        private const int RAND_MAX_VALUE = 122;

        private static Random rnd;

        static Randomizer()
        {
            rnd = new Random();
        }

        public static int GetRandomInt()
        {
            return rnd.Next(RAND_MIN_VALUE, RAND_MAX_VALUE);
        }
    }
}

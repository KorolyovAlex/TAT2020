using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4
{
    class FootsToMetersConverter : Converter
    {
        private const double METERS_IN_ONE_FOOT = 0.3048;

        public override double Convert(double value)
        {
            return value * METERS_IN_ONE_FOOT;
        }
    }
}

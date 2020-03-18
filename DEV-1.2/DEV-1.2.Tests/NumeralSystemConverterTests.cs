using NUnit.Framework;
using System;

namespace DEV_1._2.Tests
{
    [TestFixture()]
    public class NumeralSystemConverterTests
    {
        /// <summary>
        /// Tests limits for numeral system's base
        /// </summary>
        /// <param name="value">The number that should be converted</param>
        /// <param name="systemBase">Value of system base, in this test all are out of limit's range</param>
        [TestCase (13u, 0u)]
        [TestCase(25u, 1u)]
        [TestCase(2564u, 22u)]
        [TestCase(975u, 21u)]
        public void ConvertNumberIncorrectValue_Test(uint value, uint systemBase)
        {
            NumeralSystemConverter converter = new NumeralSystemConverter();

            Assert.Throws<ArgumentException>(delegate { converter.ConvertNumber(value, systemBase); });
        }

        /// <summary>
        /// Basic tests that checks correct work of method ConvertNumber
        /// </summary>
        /// <param name="value"> The number that should be converted </param>
        /// <param name="systemBase">Value of new system base</param>
        /// <param name="expected"> Expected returning value </param>
        [TestCase (7u, 2u, "111")]
        [TestCase (401u, 20u, "101")]
        public void ConvertNumber_Test(uint value, uint systemBase, string expected)
        {
            NumeralSystemConverter converter = new NumeralSystemConverter();

            Assert.AreEqual(expected, converter.ConvertNumber(value, systemBase));
        }
    }
}
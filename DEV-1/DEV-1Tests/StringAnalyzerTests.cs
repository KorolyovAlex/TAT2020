using NUnit.Framework;

namespace DEV_1.Tests
{
    [TestFixture()]
    public class StringAnalyzerTests
    {
        [TestCase (0, null)]
        [TestCase (0, "")]
        [TestCase (2, "qwysswu")]
        [TestCase (2, "qWySswU")]
        [TestCase (3, "qWyS   swu")]
        public void CountSimilarSymbolsSequenceTest(int expectedValue, string line)
        {
            StringAnalyzer stringAnalyzer = new StringAnalyzer();
            int actualValue = stringAnalyzer.CountSimilarSymbolsSequence(line);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase (0, null)]
        [TestCase (0, "")]
        [TestCase (4, "qwysswu")]
        [TestCase (4, "qWySswu")]
        [TestCase (5, "qWyS   swu")]
        public void CountDifferentSymbolsSequenceTest(int expectedValue, string line)
        {
            StringAnalyzer stringAnalyzer = new StringAnalyzer();
            int actualValue = stringAnalyzer.CountDifferentSymbolsSequence(line);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
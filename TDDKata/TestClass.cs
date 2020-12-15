// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CorrectSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "1,2";
            int expected = 3;
            int  actual = calc.Sum(op);
            
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void EmptySumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "";
            int expected = 0;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void NullSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = null;
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void WrongSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "1,!";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void NotCompletedSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = ",1";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void NewStringSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "1" + "\n" + "2";
            int expected = 3;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void DoubleSeparatorSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "1," + "\n" + "2";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void CustomSeparatorSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "//;\n1;1";
            int expected = 2;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void WrongCustomSeparatorSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "//;\n1,1";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void DoubleNewStringCustomSeparatorSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "//\n\n1,1";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void NotCompleteCustomSeparatorSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "/ \n1,1";
            int expected = -1;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ThousandSumTest()
        {
            StringCalc calc = new StringCalc();
            string op = "1002,2";
            int expected = 2;
            int actual = calc.Sum(op);

            Assert.AreEqual(actual, expected);
        }
    }
}

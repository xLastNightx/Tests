using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FibonacciClass
{
    public class TestCaseFib
    {
        [TestFixture]
        public class FibonacciTestCase
        {
            [TestCase(3, 2)]
            [TestCase(5, 5)]
            [TestCase(7, 13)]
            [TestCase(10, 55)]
            public void CurrentValue(int fibNumber, int expectedResult)
            {
                Fibonacci math = new Fibonacci();

                ClassicAssert.AreEqual(expectedResult, math.Fib(fibNumber));
            }
        }

    }
}

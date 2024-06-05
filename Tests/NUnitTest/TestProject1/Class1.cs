using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestings
{
    internal class TestCasesForNUnit
    {
        [TestFixture]
        internal class NUnitTestCase
        {
            [Test]
            public void Add()
            {
                Operations math = new Operations();
                Assert.AreEqual(15, math.Add(10, 5));
            }

            [Test]
            public void Sub()
            {
                Operations math = new Operations();
                Assert.AreEqual(20, math.Subt(30, 10));
            }
        }
    }
}

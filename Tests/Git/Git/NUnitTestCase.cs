using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    [TestFixture]
    internal class NUnitTestCase
    {
        [TestCase]
        public void Add()
        {
            Operations math = new Operations();
            Assert.Equals(15, math.Add(10, 5));
        }

        [TestCase]
        public void Sub()
        {
            Operations math = new Operations();
            Assert.Equals(20, math.Subt(30, 10));
        }
    }
}


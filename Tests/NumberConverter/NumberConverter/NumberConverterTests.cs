using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverterTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(4, 2, "100")]
        public void CurrentAnswer(int converterNumber, int converterSystem, string expectedResult)
        {
            Converter MainClass = new Converter();
            string result = MainClass.Convertation(converterNumber, converterSystem);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
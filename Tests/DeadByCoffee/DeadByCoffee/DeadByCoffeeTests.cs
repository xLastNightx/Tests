using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadByCoffeeTests
{
    [TestFixture]
    internal class DeadByCoffeeTestsCAFE
    {
        [TestCase(20051128, "CAFE forever")]
        [TestCase(20010523, "CAFE dead number 2615")]

        public void CurrentAnswerCAFE(int birthday, string expectedAnswer)
        {
            HowManyCoffee CAFETest = new HowManyCoffee();
            string answer = CAFETest.CheckForCAFE(birthday);
            Assert.AreEqual(answer, expectedAnswer);
        }
    }

    internal class DeadByCoffeeDECAF
    {
        [TestCase(20051128, "DECAF forever")]
        [TestCase(20010523, "DECAF dead number 1281")]

        public void CurrentAnswerDECAF(int birthday, string expectedAnswer)
        {
            HowManyCoffee DECAFTest = new HowManyCoffee();
            string answer = DECAFTest.CheckForDECAF(birthday);
            Assert.AreEqual(expectedAnswer, answer);
        }
    }
}

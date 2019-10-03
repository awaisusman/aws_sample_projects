using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorNS;

namespace CalculatorTest
{
    [TestClass]
    public class BasicArithmeticsTests
    {
        [TestMethod]
        public void PlusTest()
        {
            BasicArithmetics testObj = new BasicArithmetics();
            int num1, num2, res;
            num1 = 1;
            num2 = 2;
            res = 3;
            testObj.Plus(num1, num2);
            int actual = testObj.GetResult();
            Assert.AreEqual(res, actual, 0, "Plus operation not configured correctly");
        }
    }
}

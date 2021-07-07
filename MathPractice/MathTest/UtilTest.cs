using MathPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTest
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(4, Util.Add(2, 2));
            Assert.AreEqual(3, Util.Add(4, -1));
        }

        [TestMethod]
        public void TestIsDivisibleBy()
        {
            Assert.IsTrue(Util.IsDivisibleBy(4, 2));
            Assert.IsTrue(Util.IsDivisibleBy(999, 3));
            Assert.IsFalse(Util.IsDivisibleBy(7, 3));
            Assert.IsFalse(Util.IsDivisibleBy(1, 2));
        }

        [TestMethod]
        public void TestPower()
        {
            Assert.AreEqual(1, Util.Power(1, 1));
            Assert.AreEqual(8, Util.Power(2, 3));
        }
    }
}

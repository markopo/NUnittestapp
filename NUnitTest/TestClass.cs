using NUnit.Framework;
using TestApp1;

namespace NUnitTest
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void MultiplyTest()
        {
            MathsHelper mathsHelper = new MathsHelper();
            int result = mathsHelper.Multiply(5, 12); 
            Assert.AreEqual(60, result);
        }
    }
}

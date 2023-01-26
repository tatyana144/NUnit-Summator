using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTWOPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expexted = 3;

            Assert.AreEqual(actual, expexted);   
        }

        [Test]
        public void Test_Summator_SumTWONegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expexted = -100;

            Assert.AreEqual(actual, expexted);
        }

        [Test]
        public void Test_Summator_OnePositiveNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expexted = 6;

            Assert.AreEqual(actual, expexted);
        }
    }
}
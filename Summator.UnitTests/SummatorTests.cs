using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTWOPositiveNumbers()
        {
            int[] nums = new int[] { 1, 2 };
            int actual = Summator.Sum(nums);

            int expexted = 3;

            Assert.AreEqual(actual, expexted);   
        }

        [Test]
        public void Test_Summator_SumTWONegativeNumbers()
        {
            int[] nums = new int[] { -1, -99 };
            int actual = Summator.Sum(nums);

            int expexted = -100;

            Assert.AreEqual(actual, expexted);
        }

        [Test]
        public void Test_Summator_OnePositiveNumber()
        {
            int[] nums = new int[] { 6 };
            int actual = Summator.Sum(nums);

            int expexted = 6;

            Assert.AreEqual(actual, expexted);
        }
    }
}
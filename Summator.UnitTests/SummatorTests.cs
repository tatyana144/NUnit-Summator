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

            Assert.AreEqual(expexted, actual);   
        }

        [Test]
        public void Test_Summator_SumTWONegativeNumbers()
        {
            int[] nums = new int[] { -1, -99 };
            int actual = Summator.Sum(nums);

            int expexted = -100;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_OnePositiveNumber()
        {
            int[] nums = new int[] { 6 };
            int actual = Summator.Sum(nums);

            int expexted = 6;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_ZeroMumber()
        {
            int[] nums = new int[] {};
            int actual = Summator.Sum(nums);

            int expexted = 0;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_OnePositiveOneNegative()
        {
            int[] nums = new int[] {-2, 5 };
            int actual = Summator.Sum(nums);

            int expexted = 3;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoPositiveNumber()
        {
            double[] nums = new double[] { 10, 20 };
            double actual = Summator.Average(nums);

            double expexted = 15;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoNumbers()
        {
            double[] nums = new double[] { 15, 20 };
            double actual = Summator.Average(nums);

            double expexted = 17.5;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoNegativeNumbers()
        {
            double[] nums = new double[] { -50, -30 };
            double actual = Summator.Average(nums);

            double expexted = -40;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageOnepositiveOneNegative()
        {
            double[] nums = new double[] { -50, 30 };
            double actual = Summator.Average(nums);

            double expexted = -10;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateTwoPositiveNumbers()
        {
            double[] nums = new double[] { 10, 10 };
            double actual = Summator.Multiplication(nums);

            double expexted = 100;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateTwoNegativeNumbers()
        {
            double[] nums = new double[] { -20, -10 };
            double actual = Summator.Multiplication(nums);

            double expexted = 200;

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateNegativeAndPositiveNumbers()
        {
            double[] nums = new double[] { 20, -10 };
            double actual = Summator.Multiplication(nums);

            double expexted = -200;

            Assert.AreEqual(expexted, actual);
        }


    }
}
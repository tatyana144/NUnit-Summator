using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTWOPositiveNumbers()
        {
            int[] nums = { 1, 2 };
            int expexted = 3;


            int actual = Summator.Sum(nums); 

            Assert.AreEqual(expexted, actual);   
        }

        [Test]
        public void Test_Summator_SumTWONegativeNumbers()
        {
            int[] nums = { -1, -99 };
            int expexted = -100;

            int actual = Summator.Sum(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_SumOnePositiveNumber()
        {
            int[] nums = { 6 };
            int expexted = 6;

            int actual = Summator.Sum(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_SumZeroMumber()
        {
            int[] nums = {};
            int expexted = 0;

            int actual = Summator.Sum(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_SumOnePositiveOneNegative()
        {
            int[] nums = {-2, 5 };
            int expexted = 3;

            int actual = Summator.Sum(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoPositiveNumber()
        {
            double[] nums = { 10, 20 };
            double expexted = 15;

            double actual = Summator.Average(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoNumbers()
        {
            double[] nums = { 15, 20 };
            double expexted = 17.5;

            double actual = Summator.Average(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoNegativeNumbers()
        {
            double[] nums = { -50, -30 };
            double expexted = -40;

            double actual = Summator.Average(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_AverageOnepositiveOneNegative()
        {
            double[] nums = { -50, 30 };
            double expexted = -10;

            double actual = Summator.Average(nums);

            Assert.AreEqual(expexted, actual);
        }

        //AAA Pattern
        [Test]
        public void Test_Summator_AverageThreePositiveNumbers()
        {

            //Arrange
            double[] nums = { 10, 20, 30 };
            double expexted = 20;

            //Act
            double actual = Summator.Average(nums);

            //Assert
            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateTwoPositiveNumbers()
        {
            double[] nums = { 10, 10 };
            double expexted = 100;

            double actual = Summator.Multiplication(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateTwoNegativeNumbers()
        {
            double[] nums = { -20, -10 };
            double expexted = 200;

            double actual = Summator.Multiplication(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_MultiplicateNegativeAndPositiveNumbers()
        {
            double[] nums = { 20, -10 };
            double expexted = -200;

            double actual = Summator.Multiplication(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_DivisionTwoPositiveNumbers()
        {
            double[] nums = { 20, 10 };
            double expexted = 2;

            double actual = Summator.Division(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_DivisionPositiveByNegativeNumber()
        {
            double[] nums = { 30, -2 };
            double expexted = -15;

            double actual = Summator.Division(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_DivisionTwoNegativeNumbers()
        {
            double[] nums = { -30, -2 };
            double expexted = 15;

            double actual = Summator.Division(nums);

            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void Test_Summator_DivisionSmallerNumberByBigger()
        {
            double[] nums = { 10, 20};
            double expexted = 0.5;

            double actual = Summator.Division(nums);

            Assert.AreEqual(expexted, actual);
        }


    }
}
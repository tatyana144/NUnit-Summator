using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        // Test method for sum of array from numbers
        public static int Sum(int[] arr)
        {

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];

            }

            return sum;
        }

        public static double Average(double[] arr)
        {

            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];

            }

            return sum / arr.Length;
        }

        public static double Multiplication(double[] arr)
        {

            double multiplication = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                multiplication *= arr[i];

            }

            return multiplication;
        }

        public static double Division(double[] arr)
        {

            double division = 0;
            double result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                division = arr[i];

                if (result == 0)
                {
                    result = division;
                }
                else
                {
                    result /= division;
                }

            }

            return result;
        }

    }
}

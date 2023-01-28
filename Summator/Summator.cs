using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        // Test mwthod for sum of array from numbers
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

            double mult = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                mult *= arr[i];

            }

            return mult;
        }

    }
}

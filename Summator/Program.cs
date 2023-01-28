namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is =  " + Summator.Sum(new int[] { 1, 2, 3 }));

            double[] arr = { 20, 10 };
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

            Console.WriteLine(result);


        }
    }
}
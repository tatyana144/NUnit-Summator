namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is =  " + Summator.Sum(new int[] { 1, 2, 3 }));

            double[] arr = new double[] { 10, 10};

            double mult = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                mult *= arr[i];

            }

            
            Console.WriteLine(mult);
        }
    }
}
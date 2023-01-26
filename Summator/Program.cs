namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is =  " + Summator.Sum(new int[] { 1, 2, 3 }));
            Summator.Test_SumTwoNumbers();
        }
    }
}
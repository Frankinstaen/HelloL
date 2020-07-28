using System;
namespace ConsoleAppz
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = seriesSum(2);
            Console.WriteLine(k);

        }
        public static string seriesSum(int n)
        {
            double sum = 0;
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += ((double)1) / count;
                count += 3;
            }
            return Math.Round(sum, 2).ToString("0.00");
        }
    }
}

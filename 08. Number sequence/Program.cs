using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = -1000000000000000;
            double min = 1000000000000000;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
        }
    }
}
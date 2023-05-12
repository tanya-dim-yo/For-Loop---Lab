using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumOdd);
            }
            else
            {
                int diff = Math.Abs(sumEven - sumOdd);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
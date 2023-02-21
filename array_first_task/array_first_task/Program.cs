using System;

namespace array_task_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 5, 4, 5, 6 };
            int sum = 0;
            int count = 0;
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    sum+=numbers[i];
                    count++;
                }
            }
            result = sum/count;
            Console.WriteLine(result);

        }
    }
}

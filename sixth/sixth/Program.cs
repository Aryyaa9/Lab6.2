using System;
namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int k = random.Next(1, 20);

            double[] nums = new double[k];
            double[] posNums = new double[k];
            double[] negNums = new double[k];
            int p = 0;
            int n = 0;

            for (int i = 0; i < k; i++)
            {
                nums[i] = (double)random.NextDouble() * 200 - 100;
                Console.Write(nums[i] + " ");
                if (nums[i] >= 0)
                {
                    posNums[p] = nums[i];
                    p++;
                }
                else
                {
                    negNums[n] = nums[i];
                    n++;
                }
            }

            Console.WriteLine();
            
            for (int i = 0; i < p; i++)
            {
                Console.Write(posNums[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(negNums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

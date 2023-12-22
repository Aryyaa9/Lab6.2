using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // положит-ое число
            int num = 0;
            int sum = 0;

            while (num >= 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num % a == 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
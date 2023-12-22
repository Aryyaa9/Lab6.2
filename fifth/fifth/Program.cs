using System;
namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[n, m + 1];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int count = 0; //для подсчета единиц в каждой строке

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 1)
                        count++;
                }
                
                // для создания еще 1го столбца 
                if (count % 2 == 0)
                    matrix[i, m] = 0;
                else
                    matrix[i, m] = 1;
                count = 0;
            }
            Console.WriteLine();

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
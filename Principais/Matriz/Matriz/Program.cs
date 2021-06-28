using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] position = Console.ReadLine().Split(' ');

            int countx = int.Parse(position[0]);
            int county = int.Parse(position[1]);

            int[,] mat = new int[countx, county];

            for (int i = 0; i < countx; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for (int j = 0; j < county; j++)
                {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < countx; i++)
            {
                for (int j = 0; j < county; j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine("Position " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < county - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < countx - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int r1, c1, r2, c2;

        Console.WriteLine("Enter rows of first matrix:");
        r1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter columns of first matrix:");
        c1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter rows of second matrix:");
        r2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter columns of second matrix:");
        c2 = Convert.ToInt32(Console.ReadLine());

        if (c1 != r2)
        {
            Console.WriteLine("Matrix multiplication not possible");
            return;
        }

        int[,] A = new int[r1, c1];
        int[,] B = new int[r2, c2];
        int[,] C = new int[r1, c2];

        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < r2; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < c1; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

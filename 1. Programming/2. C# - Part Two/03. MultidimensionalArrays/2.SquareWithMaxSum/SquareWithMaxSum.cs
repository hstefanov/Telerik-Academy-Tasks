using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3
/// that has maximal sum of its elements.
/// </summary>

class SquareWithMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix :");
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int M = int.Parse(Console.ReadLine());

        //matrix
        int[,] matrix = new int[N, M];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter value for matrix[{0},{1}] : ",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        //Print result
        Console.WriteLine("The best platform is :");
        Console.WriteLine("{0} {1} {2} ", matrix[bestRow, bestCol], 
                                          matrix[bestRow, bestCol + 1],
                                          matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0} {1} {2} ", matrix[bestRow + 1, bestCol],
                                          matrix[bestRow + 1, bestCol + 1],
                                          matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}


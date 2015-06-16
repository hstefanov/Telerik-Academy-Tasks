using System;

class SubsetSumProblem
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col + 1;
            }
        }

        PrintMatrix(matrix);
    }
}


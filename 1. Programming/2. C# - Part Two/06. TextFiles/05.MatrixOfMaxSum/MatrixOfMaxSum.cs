using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that reads a text file containing a square matrix of numbers 
/// and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
/// The first line in the input file contains the size of matrix N. 
/// Each of the next N lines contain N numbers separated by space. 
/// The output should be a single number in a separate text file.
/// </summary>

class MatrixOfMaxSum
{
    private static int GetRows(string fileName)
    {
        string line = string.Empty;
        int rows = 0;
        using (StreamReader reader = new StreamReader(fileName))
        {
            line = reader.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    rows++;
                }
            }
        }
        return rows;
    }

    private static int GetCols(string fileName)
    {
        int cols = 0;
        string line = string.Empty;
        using (StreamReader reader = new StreamReader(fileName))
        {
            line = reader.ReadLine();
            while (line != null)
            {
                cols++;
                line = reader.ReadLine();
            }
        }
        return cols;
    }

    private static int[,] FillMatrix(string fileName,int[,] matrix)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] nums = reader.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = int.Parse(nums[col]);
                }
            }
        }
        return matrix;
    }

    private static int[,] Matrix(string fileName)
    {
        int rows = GetRows(fileName);
        int cols = GetCols(fileName);
        int[,] matrix = new int[rows, cols];
        matrix = FillMatrix(fileName,matrix);
        return matrix;
    }

    private static void MaxSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The best platform is :");
        Console.WriteLine("{0} {1}", matrix[bestRow, bestCol],
                                          matrix[bestRow, bestCol + 1]);
        Console.WriteLine("{0} {1}", matrix[bestRow + 1, bestCol],
                                          matrix[bestRow + 1, bestCol + 1]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }

    static void Main()
    {
        int[,] matrix = Matrix("matrix.txt");
        MaxSum(matrix);
    }
}

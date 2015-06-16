using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that fills and prints a matrix of size (n, n) as shown below
/// </summary>

class FillAndPrintMatrix
{
    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        //Enter size of the matrix
        Console.Write("Enter size of the matrix  ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        // a)
        //Initialize matrix
        Console.WriteLine("a)");
        int value = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = value++;
            }
        }

        //Print
        PrintMatrix(matrix);

        //Clear matrix
        Array.Clear(matrix, 0, matrix.Length);

        // b)
        //Initialize matrix
        Console.WriteLine("b)");
        value = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = value++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) -1 ; row  >= 0; row--)
                {
                    matrix[row, col] = value++;
                }
            }
        }

        //Print matrix
        PrintMatrix(matrix);

        //Clear matrix
        Array.Clear(matrix, 0, matrix.Length);

        // c)
        //Initialize matrix
        Console.WriteLine("c)");
        value = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1) - row; col++)
            {
                matrix[row + col, col] = value++;
            }
        }
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(1) - col; row++)
            {
                matrix[row, col + row] = value++;
            }
        }

        //Print matrix
        PrintMatrix(matrix);

        //Clear matrix
        Array.Clear(matrix, 0, matrix.Length);

        // d)
        //Initialize matrix
        Console.WriteLine("d)");
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= (int)Math.Pow(size,2); i++)
        {
            if (direction == "down" && (currentRow >= size || matrix[currentRow,currentCol] != 0))
            {
                direction = "right";
                currentCol++;
                currentRow--;
            }
            else if (direction == "right" && (currentCol >= size || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

            matrix[currentRow,currentCol] = i;

            // directions
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        PrintMatrix(matrix);
    }
}

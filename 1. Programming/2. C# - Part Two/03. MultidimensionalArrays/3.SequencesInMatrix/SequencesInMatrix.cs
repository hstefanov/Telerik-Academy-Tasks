using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SequencesInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix :");
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int M = int.Parse(Console.ReadLine());

        //Initialize matrix
        /*
        string[,] matrix = new string[N, M];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter value for matrix[{0},{1}] : ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
            Console.WriteLine();
        }
        */

        string[,] matrix = new string[,]
        {
            {"ha", "fifi", "ho", "xx" },
            {"hi", "ha", "xx", "xx" },
            {"xx", "xx", "ha", "xi" },
            {"xx", "ha", "ha", "ha" }
        };

        int count = 1;
        int bestCount = 1;
        int bestRow = 0;
        int bestCol = 0;

        //check vertical
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            count = 1;
        }

        //check horizontal
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            count = 1;
        }

        //check diagonals
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                // down right
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (row + i > matrix.GetLength(0) - 1 || col + i > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row + i, col + i])
                    {
                        count++;

                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }

                count = 1;
                // top rigth
                for (int i = 1; i < matrix.GetLength(1); i++)
                {
                    if (row - i < 0 || col + i > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row - i, col + i])
                    {
                        count++;

                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
            }
        }
        if (bestCount > 1)
        {
            string result = matrix[bestRow, bestCol];
            for (int i = 0; i < bestCount - 1; i++)
            {
                Console.Write(result + ", ");
            }
            Console.Write(result);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no sequence in the matrix");
        }
    }
}

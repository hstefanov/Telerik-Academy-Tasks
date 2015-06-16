namespace Matrix
{
    using System;

    class MatrixTest
    {
        static void Main()
        {
            int[,] matrix = new int[5,5];
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(0, 100) + 1;
                }
            }

            Matrix<int> firstMatrix = new Matrix<int>(5, 5, matrix);
            firstMatrix.Print();
        }
    }
}

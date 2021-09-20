using System;
public class Exercise1
{
    public static void Main()
    {
        Console.Write("First matrix:\n");
        int[,] matrix1 = GenerateRandomMatrix();
        int[] size = GetSizeOfMatrix(matrix1);
        PrintMatrix(matrix1);

        Console.Write("\nSecond matrix:\n");
        int[,] matrix2 = GenerateRandomMatrix(size);
        PrintMatrix(matrix2);

        Console.Write("\nAdded matrices:\n");
        int[,] combined = AddMatrices(matrix1, matrix2, size);
        PrintMatrix(combined);

        Console.Write("\nSubtracted matrices:\n");
        int[,] subtracted = SubtractMatrices(matrix1, matrix2, size);
        PrintMatrix(subtracted);

        Console.Write("First new matrix:\n");
        matrix1 = GenerateRandomMatrix();
        size = GetSizeOfMatrix(matrix1);

        PrintMatrix(matrix1);

        Console.Write("\nSecond new matrix:\n");
        Array.Reverse(size);
        matrix2 = GenerateRandomMatrix(size);
        PrintMatrix(matrix2);

        Console.Write("\nMultiplied matrices:\n");
        int[,] multiplied = Multiply(matrix1, matrix2);
        PrintMatrix(multiplied);

    }
    public static int[,] GenerateRandomMatrix(params int[] size)
    /*If there's no parameters, function creates random size array with random numbers
    /*You can create custom size matrix if you give size array as parameter.        */
    {
        Random rnd = new Random();
        int iSize, jSize;

        if (size.Length != 0)
        {
            iSize = size[0];
            jSize = size[1];
        }
        else
        {
            iSize = rnd.Next(1, 10);
            jSize = rnd.Next(1, 10);
        }

        int[,] matrix = new int[iSize, jSize];

        for (int i = 0; i < iSize; i++)
        {
            for (int j = 0; j < jSize; j++)
            {
                matrix[i, j] = rnd.Next(0, 50);
            }
        }
        return matrix;
    }
    public static int[] GetSizeOfMatrix(int[,] matrix)
    /*GetSizeOfMatrix returns dimensions of 2d array as int array*/
    {
        int i = 0, j = 0;

        for (int dimension = 1; dimension <= matrix.Rank; dimension++)
        {
            if (dimension == 1)
            {
                j = matrix.GetUpperBound(dimension - 1) + 1;
            }
            else
            {
                i = matrix.GetUpperBound(dimension - 1) + 1;
            }
        }
        int[] size = new int[] { j, i };
        return size;
    }
    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2, params int[] size)
    {
        int[,] matrixAdded = new int[size[0], size[1]];

        for (int i = 0; i < size[0]; i++)
        {

            for (int j = 0; j < size[1]; j++)
            {
                matrixAdded[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrixAdded;
    }
    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2, params int[] size)
    {
        int[,] matrixsubtracted = new int[size[0], size[1]];

        for (int i = 0; i < size[0]; i++)
        {

            for (int j = 0; j < size[1]; j++)
            {

                matrixsubtracted[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return matrixsubtracted;
    }
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}\t", matrix[i, j]);
            }
            Console.Write("\n");
        }
    }

    public static int[,] Multiply(int[,] A, int[,] B)
    {
        int rA = A.GetLength(0);
        int cA = A.GetLength(1);
        int rB = B.GetLength(0);
        int cB = B.GetLength(1);
        int temp = 0;
        int[,] multiplied = new int[rA, cB];
        if (cA != rB)
        {
            Console.WriteLine("matrix can't be multiplied !!");
            return null;
        }
        else
        {
            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    multiplied[i, j] = temp;
                }
            }
            return multiplied;
        }
    }
}
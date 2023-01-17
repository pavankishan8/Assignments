using System;

class Matrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element [" + (i + 1) + "," + (j + 1) + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        int[] rowSums = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += matrix[i, j];
            }
            rowSums[i] = rowSum;
        }

        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.Write("| " + rowSums[i]);
            Console.WriteLine();
        }
    }
}

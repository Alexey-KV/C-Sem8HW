// Num 56
// задать прямоугольный двумерный массив; 
// найти строку с наименьшей суммой элементов; 
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int RowSmallestSum(int[,] inputMatrix)
{
    int sumTemp = 0, sum = 0, rowMin = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        sumTemp = 0;

        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (i < 1) sum += inputMatrix[i, j];

            sumTemp += inputMatrix[i, j];
        }

        if (sumTemp < sum)
        {
            sum = sumTemp;
            rowMin = i;
        }
    }
    return rowMin;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        Console.Write($"{i+1}\t");
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetMatrix(5, 5);
System.Console.WriteLine("Source array:");
PrintMatrix(array);
int rowMin = RowSmallestSum(array);
System.Console.WriteLine($"The row with the smallest sum: {rowMin + 1}");

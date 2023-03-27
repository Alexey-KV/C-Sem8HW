// Num 54
// задайте двумерный массив; напишите программу,
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива;
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetMatrix(int lines, int cols)
{
    int[,] arr = new int[lines, cols];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int[,] SortRowsMatrix(int[,] inputMatrix)
{
    int temp=0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1)-1; j++)
        {
            for (int k = j + 1; k < inputMatrix.GetLength(1); k++)
            {
                if (inputMatrix[i,j] < inputMatrix[i,k])
                {
                    temp = inputMatrix[i,j];
                    inputMatrix[i,j] = inputMatrix[i,k];
                    inputMatrix[i,k] = temp;
                }
            }
        }
    }
    return inputMatrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            System.Console.Write(inputMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of col-s: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] inputMatrix = GetMatrix(lines, cols);
PrintMatrix(inputMatrix);
Console.WriteLine("\nArray rows sorted in descending order:");
PrintMatrix(SortRowsMatrix(inputMatrix));

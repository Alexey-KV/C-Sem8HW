// Num 60
// сформируйте трёхмерный массив из неповторяющихся двузначных чисел; 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента;
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Get3DMatrixNoRepeat(int[,,] arr, int minVal, int maxVal)
{
    int temp;
    bool check = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Random rnd = new Random();
                temp = rnd.Next(minVal, maxVal);
                check = RepeatCheck(arr, temp);
                if (check)
                {
                    arr[i, j, k] = temp;
                }
                else
                {
                    k--;
                }
            }
        }

    }
    return arr;
}

bool RepeatCheck(int[,,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i,j,k] == value)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int Enter(string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int depth = Enter("Enter the length of the third dimension: ");
int row = Enter("Enter the length of the second dimension: ");
int column = Enter("Enter the length of the first dimension: ");
int min = Enter("Enter the minimum number value: ");
int max = Enter("Enter the maximum number value: ");

if (depth * row * column > max - min)
    {
        System.Console.WriteLine("Non-repeating values are less than array size");
        Environment.Exit(0);
    }

int[,,] array = new int[depth, row, column];
array = Get3DMatrixNoRepeat(array, min, max);

Console.Clear();
PrintMatrix(array);
Console.WriteLine();

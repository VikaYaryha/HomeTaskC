// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void OutputMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
int[,] matrix = new int[4, 4];
int j = 0;
int i = 0;
int number = 1;
int count = 0;

int kj = matrix.GetLength(0) - 1; //3
int ki = matrix.GetLength(1) - 1; //3

while (count < matrix.GetLength(0) * matrix.GetLength(1))
{
    while (kj - j >= 0 && count < matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number++;
        count++;
        j++;
    }
    j--;
    i++;
    kj--;


    while (ki - i >= 0 && count < matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number++;
        count++;
        i++;
    }
    i--;
    j--;
    ki--;

    while (kj - j <= kj && count < matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number++;
        count++;
        j--;
    }
    j++;
    i--;


    while (ki + i > ki && count < matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number++;
        count++;
        i--;
    }
    i++;
    j++;
}

OutputMatrix(matrix);









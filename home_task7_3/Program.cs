// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Исходный массив: ");
InputMatrix(matrix);

for (int k = 0; k < matrix.GetLength(1); k++)
{
    int m=0;
    double sum = 0;
    double mean = 0;
    while (m< matrix.GetLength(0))
    {
        sum += matrix [m,k];
        m++;            
    }
    mean = Math.Round(sum/matrix.GetLength(0), 3);
    Console.WriteLine($"Среднее арифметическое {k+1}-го столбца: {mean}");
}





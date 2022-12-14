// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

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



Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Исходный массив: ");
InputMatrix(matrix);

Console.Write("Введите позицию элемента: ");
string [] position = Console.ReadLine().Split(" ");
if (int.Parse(position[0]) >= matrix.GetLength(0) || int.Parse(position[1]) >= matrix.GetLength(1))
    Console.Write("такой позиции в массиве нет");
else 
    Console.Write(matrix[int.Parse(position[0]), int.Parse(position[1])]);





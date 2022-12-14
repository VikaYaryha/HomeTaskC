//Миша и негатив

void InputMatrix(string [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Console.ReadLine();
        }

        Console.WriteLine();
    }
}


void OutputMatrix(string [,] matrix)
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
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
string [,] picture = new string [int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Введите W и B исходного изображения: ");
InputMatrix(picture);
OutputMatrix(picture);
string [,] pictureMisha = new string [int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Введите W и B мишиного изображения: ");
InputMatrix(pictureMisha);
OutputMatrix(pictureMisha);

int count = 0;
for (int i = 0; i < picture.GetLength(0); i++)
    {
        for (int j = 0; j < picture.GetLength(1); j++)
        {
            if (picture [i,j] != pictureMisha [i,j])
            count++;
        }

    }

Console.WriteLine($"Количество неправильно сформированных пикселей: {count}");

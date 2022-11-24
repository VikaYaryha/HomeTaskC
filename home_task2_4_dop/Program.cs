Console.Clear();

int max1 = 0;
int max2 = 0;
Console.WriteLine("Введите неотрицательные целые числа, не превышающих значения 100: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n != 0)
{
    if (n > max2 && n < max1)
        max2 = n;
    
    else if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
       
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("end");
Console.Write($"Второе максимальное число {max2}");
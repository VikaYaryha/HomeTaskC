Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.Write ("число "+ a + " больше числа "+ b);
else if ( b > a)
    Console.Write ("число "+ b+ " больше числа "+a);
else
    Console.Write ("введенные числа равны между собой");
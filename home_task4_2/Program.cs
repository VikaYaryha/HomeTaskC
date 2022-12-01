// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// string? n = Console.ReadLine();
// int sum = 0;
// for (int i=0; i<n.Length; i++)
// {
//        sum += Convert.ToInt32(n[i].ToString());
// }
// Console.WriteLine(sum);

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n/10 > 1)
{
    sum += n%10;
    n=n/10;
}
sum +=n;

Console.WriteLine(sum);
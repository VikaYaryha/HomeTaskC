Console.Clear();
Console.Write("введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int i=1; 
if (n>1)
{
    while (i<=n)
    {
        if (i%2==0)
            Console.Write ($"{i} ");
            i++;
    }
    
}
else
    Console.Write("Вы ввели число меньше 1");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100) 
    Console.Write("третьей цифры нет");
else
    while (n>=1000)
    {
        n/=10;
        Console.Write(n%10);
    }
        
    


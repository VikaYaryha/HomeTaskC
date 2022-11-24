Console.Clear();

int n = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {n}");
int n2 = ( n / 10) % 10; 

Console.Write(n2);


// Или "ручной" способ указан ниже:

// Console.Write("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = ( n / 10) % 10; 

// Console.Write(n2);
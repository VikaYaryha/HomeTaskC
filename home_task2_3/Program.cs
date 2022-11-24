Console.Write("Введите числом день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
    Console.Write("выходной день");
else if ( n >0 && n < 6)
    Console.Write("будний день");
else
    Console.Write("введено не корректное число");


Console.Clear();
Console.Write("Введите количество кустов черники (от 3 до 1000): ");
int a = Convert.ToInt32(Console.ReadLine());
int [] berry = new int [a];
for (int i = 0; i < a; i++)
{
    Console.Write("Введите количество ягод (не более 1000): ");
    berry[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(String.Join(", ", berry));

int max=0;

for (int i = 0; i+2 < a; i++)
{
    if ((berry[i]+berry[i+1]+berry[i+2]) > max)
        max = berry[i]+berry[i+1]+berry[i+2];
    if ((berry[0]+berry[a-1]+berry[a-2]) > max)
        max = berry[0]+berry[a-1]+berry[a-2];
    if ((berry[0]+berry[1]+berry[a-1]) > max)
         max = berry[0]+berry[1]+berry[a-1];
}

Console.Write(max);





// Дана последовательность из N целых чисел и число K. 
//Необходимо сдвинуть всю последовательность (сдвиг - циклический)
// на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int [] array2 = new int [n];
for (int position = 0; position < n; position++)
{
    array[position] = new Random().Next(0,101);
}
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.Write("Введите насколько сдвинуть массив: ");
int k = Convert.ToInt32(Console.ReadLine());
int j=0;
int i=0;

if (k>0)
{
    while ((j<n) && (i<n))
    {
        if ((i-k)>=0)
        {
           array2[j]=array[i-k];
        }   
        else
        {
            array2[j]=array[i-k+array.Length];
        }
        i++;
        j++;
    }
    

}
else if (k<0)
{
    while ((j<n) && (i<n))
    {
        if ((i-k)<array.Length)
        {
           array2[j]=array[i-k];
        }   
        else
        {
            array2[j]=array[i-k-array.Length];
        }
        i++;
        j++;
    }
}
else
{
    while ((j<n) && (i<n))
    {
        array2[i]=array[j];
        i++;
        j++;  
    }
   
}
Console.WriteLine($"[{string.Join(", ", array2)}]");


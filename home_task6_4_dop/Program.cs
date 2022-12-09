//По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

double side (int a1, int b1, int a2, int b2)
{
    double ab= Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1));
    return ab;
}


Console.Clear();
Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double xy = side(x1,y1,x2,y2);
double xz = side(x1,y1,x3,y3);
double yz = side(x3,y3,x2,y2);

double S = Math.Sqrt (((xy+xz+yz)/2)*(((xy+xz+yz)/2)-xy)*(((xy+xz+yz)/2)-xz)*(((xy+xz+yz)/2)-yz));

Console.Write($"Площадь треугольника: {S}");




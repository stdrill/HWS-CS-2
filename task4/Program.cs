// Найти расстояние между точками в пространстве 2D

Console.Write("Введите значение x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double rasst = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
if (rasst % 1 != 0){
    Console.WriteLine("Расстояние между точками " + rasst.ToString("F" +3));
} else {
    Console.WriteLine("Расстояние между точками " + rasst);
}

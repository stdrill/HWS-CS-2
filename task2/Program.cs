// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine()); 
if (a == b * b){
    Console.WriteLine("{0} является квадратом {1}", a, b);
} else if (b == a * a){
    Console.WriteLine("{1} является квадратом {0}", a, b);
} else {
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
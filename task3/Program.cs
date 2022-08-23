// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1){
    Console.WriteLine("[10, 10]");
} else if (a == 2){
    Console.WriteLine("[-10, 10]");
} else if (a == 3) {
    Console.WriteLine("[-10, -10]");
} else if (a == 4) {
    Console.WriteLine("[10, -10]");
} 
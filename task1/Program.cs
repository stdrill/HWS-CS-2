// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string[] arrayWeek = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
Console.WriteLine("Введите порядковый номер: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= arrayWeek.Length && n > 0){
    if (n <=5){
    Console.WriteLine("{0} будний день", arrayWeek[n - 1]);}
    if (n > 5 && n <= arrayWeek.Length){
        Console.WriteLine("{0} выходной день!", arrayWeek[n - 1]);
    }
}else {
    Console.WriteLine("Введеное число не совпадает с днем недели");
}
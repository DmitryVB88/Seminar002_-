Console.WriteLine("Введите числа x и y");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}

// Console.WriteLine("Введите пятизначное число:");
// string number = Console.ReadLine();

// if( number < 10000 && number > 99999)
// {
//     Console.WriteLine($"Введенное число {number} не явлеяется пятизначным");
// }
// if (number[0] == number[4] && number[1] == number[3])
// {
//      Console.WriteLine($"Поздравляю число {number} палиндром");
// }
// else 
// {
//     Console.WriteLine($"Извините, число {number} не является палиндромом");
// }

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if(number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
    Console.WriteLine("Поздравляю, данное число является палиндромом!");
}
else
{
    Console.WriteLine("Это не палиндром. Попробуйте еще раз.");
}

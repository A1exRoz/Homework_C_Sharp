// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 9999 || n > 99999)
{
    Console.Write("Вы ввели не верное число! \nвведите 5-ти значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if ((n % 10 == n / 10000) && ((n / 10) % 10 == (n / 1000) % 10))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}


// Вот так еще решали эту задачу:

// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;

// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// Через подсчет строк:

// Console.Write("Введите пятизначное число: ");
// string? n = Console.ReadLine();
// if (n[0] == n[4] && n[1] == n[3])
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// Вообще любое число можно проверить вот так:

// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = n;
// int newNumber = 0, i = Convert.ToString(n).Length - 1;
// while (i >= 0)
// {
//     newNumber = newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
//     n = n / 10;
//     i--;
// }
// Console.WriteLine(newNumber == result);

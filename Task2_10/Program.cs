// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное число число: ");
int a = Convert.ToInt32(Console.ReadLine());
while ( a < 100 || a > 999 )
{
    Console.Write("Вы ввели не верное число \nВведите трехзначное число: "); 
    a = Convert.ToInt32(Console.ReadLine());
}
int a1 = a / 10;
int a2 = a1 % 10; 
Console.Write(a2);
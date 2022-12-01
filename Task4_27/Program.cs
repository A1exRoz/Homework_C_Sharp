// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (n / 10 != 0)
{
    result += n % 10;
    n /= 10;
}
result += n;
Console.WriteLine(result);
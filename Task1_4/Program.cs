// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int[] num = new Int32[] { a, b, c};
int i = 0;
int max = num[i];
int countMax = 0;
while (i < num.Length)
{
    if (num[i] > max)
    {
        max = num[i];
        countMax = 1;
    }
    else 
    {
        if (num[i] == max)
            countMax
}
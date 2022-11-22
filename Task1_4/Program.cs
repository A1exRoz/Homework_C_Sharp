// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a >= b && a >= c)
    max = a;
else if (b >= a && b >= c)
    max = b;
else if (c >= a && c >= b)
    max = c;
Console.WriteLine("Максимальное число: " + max);



//хотел сделать через массив но пока не умею) обязательно потом сделаю
// int[] num = new Int32[] { a, b, c};
// int i = 0;
// int max = num[i];
// int countMax = 0;
// while (i < num.Length)
// {
//     if (num[i] > max)
//     {
//         max = num[i];
//         countMax = 1;
//     }
//     else 
//     {
//         if (num[i] == max)
//             countMax++;
//     }
//     i++;
// }
// Console.Write(countMax);
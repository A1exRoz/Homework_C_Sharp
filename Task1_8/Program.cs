// Напиcать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++) 
{ 
    if (i % 2 == 0) 
    Console.Write (i + "  " ); 
}

//работает еще вот так:
// for (int i = 2; i <= n; i+=2)
// {
//     if (i + 2 > n)
//         Console.Write($"{i}");
//     else
//         Console.Write($"{i}, ");
// }


//потом тоже надо доделать)))
// int i = 1;
// while (i <= n && i % 2 == 0)
// {
//     Console.Write($"{i} ");
//     i++;
// }
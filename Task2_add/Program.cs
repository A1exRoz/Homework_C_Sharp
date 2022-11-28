// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int max1 = Convert.ToInt32(0);
int max2 = Convert.ToInt32(0);
while (n != 0)
{
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2);
    {
        max2 = n;
    }
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Второе максимальное число: ");
Console.WriteLine(max2);
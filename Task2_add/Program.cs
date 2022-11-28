// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();

Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > maxFirst)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (n > maxSecond)
        maxSecond = n;
}
Console.WriteLine(maxSecond);

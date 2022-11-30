Console.Clear();

//Условие
Console.Write("Введите колличество кустов на поляне, от 3 до 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 3 || n > 1000)
{
    Console.WriteLine("Вы задали не верное колличество кустов, введите колличество кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[n];
Console.WriteLine("Введите колличество ягод на каждом кусте: ");
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

//Решение
int maxsum = 0;
int cursum = 0;
for (int i = 0; i < n - 2; i++)
{
    cursum = a[i] + a[i + 1] + a[i + 2];
    if (cursum > maxsum) 
    { 
        maxsum = cursum;
    }
}
if (a[0] + a[n - 1] + a[n - 2] > maxsum)
    maxsum = a[0] + a[n - 1] + a[n - 2];

else if (a[0] + a[1] + a[-1] > maxsum)
    maxsum = a[0] + a[1] + a[n - 1];

Console.Write(maxsum);
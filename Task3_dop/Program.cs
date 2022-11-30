Console.Clear();

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
    a[i] = Convert.ToInt32(Console.ReadLine());

int max = 0;
int i = 0;
if (i <= n - 1) 
{ 
    (a[i] + a[i + 1] + a[i + 2]) > max;
    sum > max;
}
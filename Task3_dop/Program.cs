Console.Clear();

Console.Write("Введите колличество кустов на поляне, от 3 до 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 3 || n > 1000)
{
    Console.WriteLine("Вы задали не верное колличество кустов, введите колличество кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[n];
int x = a.Length;
Console.WriteLine("Введите колличество ягод на каждом кусте: ");

for (int i = 0; i < x; i++)
    a[i] = int.Parse(Console.ReadLine());
int i = 0;
int max = 0;
if (i <= x - 1) 
{ 
    (a[i] + a[i + 1] + a[i + 2]) > max;
    sum > max;
    
}
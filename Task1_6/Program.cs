Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ( n % 2 == 0)
    Console.WriteLine("Вы ввели четное число");
else
    Console.WriteLine("Вы ввели нечетное число");
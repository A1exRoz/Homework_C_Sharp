// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  y = k1 * x + b1
//  y = k2 * x + b2

Console.Clear();
Console.Write("Ведите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = Convert.ToDouble((b1 - b2) / (k2 - k1));
double y = Convert.ToDouble(k2 * x + b2);

Console.WriteLine($"Точки пересечения: [{string.Join("; ", x, y)}]");

// вот так решил Денис через двухмерный массив
// Console.Clear();

// Console.Write("Введите k и b первой прямой: ");
// string[] numbersFirst = Console.ReadLine().Split(" ");
// double k1 = double.Parse(numbersFirst[0]);
// double b1 = double.Parse(numbersFirst[1]);
// Console.Write("Введите k и b второй прямой: ");
// string[] numbersSecond = Console.ReadLine().Split(" ");
// double k2 = double.Parse(numbersSecond[0]);
// double b2 = double.Parse(numbersSecond[1]);
// Console.WriteLine((b2 - b1) / (k1 - k2));
// Console.WriteLine(k2 * (b2 - b1) / (k1 - k2) + b2);

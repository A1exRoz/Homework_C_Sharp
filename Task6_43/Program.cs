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
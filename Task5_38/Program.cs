﻿// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}


double ReleaseArray(double[] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) 
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    diff = max - min;
    return min;
}



Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");
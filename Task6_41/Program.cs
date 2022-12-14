// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2      -> 2
// 1, -7, 567, 89, 223  -> 3

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}



Console.Clear();
Console.Write("Введите сколько будет чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Чисел больше 0: {ReleaseArray(array)}");


// Вот так решил Денис на сминаре

// Console.Write("Введите кол-во чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if (Convert.ToInt32(Console.ReadLine()) > 0)
//         count++;
// }
// Console.WriteLine(count);


// Или вот так

// string[] n = Console.ReadLine().Split(" ");
// int count = 0;
// foreach (string i in n)
// {
//     if (int.Parse(i) > 0)
//         count++;
// }
// Console.WriteLine(count);

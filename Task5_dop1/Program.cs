// Задача №5     Статистика
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=703

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}


void ReleaseArray(int[] array)
{
    int sum3 = 0, sum4 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum4 ++;
        else
            sum3 ++;
    }
    Console.WriteLine($"Сумма четверок {sum4}");
    Console.WriteLine($"Сумма троек {sum3}");
    
    if (sum4 > sum3)
        Console.WriteLine("yes");
    else Console.WriteLine("no");
}

// string result(int[] array, int sum3, int sum4)
// {
//     if (sum4 > sum3)
//         return "yes";
//     return "no";
// }

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join("  ", array)}]");
ReleaseArray(array);
// Console.WriteLine(result(array, sum3, sum4));
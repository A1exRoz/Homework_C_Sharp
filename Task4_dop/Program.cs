// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический)
// на |K| элементов вправо, если K – положительное 
// и влево, если отрицательное.

// Первая строка содержит натуральное число N, 
// во второй строке записаны N целых чисел Ai, 
// а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).


Console.Clear();
Console.Write("Введите кол-во элементов массивва: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] arrayHelp = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"[{string.Join(", ", array)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayHelp[i] = array[array.Length - k + i];
    for (int i = 0; i < array.Length - k; i++)
        arrayHelp[k + i] = array[i];
    
    Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        arrayHelp[array.Length - k + i] = array[i];
    for (int i = 0; i < array.Length - k; i++)
        arrayHelp[i] = array[k + i];
    Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
}

// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический)
// на |K| элементов вправо, если K – положительное 
// и влево, если отрицательное.

// Первая строка содержит натуральное число N, 
// во второй строке записаны N целых чисел Ai, 
// а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).


Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(0, 10);

int count = array.Length;

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }   
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
Console.Write(array);
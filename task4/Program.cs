//  Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] arr = GetRandomArray(5, -150, 150);

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>= 10 && arr[i]<=99) 
    {
        count ++;
    }
}

PrintArray(arr);

// System.Console.WriteLine($"колличество элеиентов массива в отрезке [10,99] = {count});

System.Console.WriteLine("колличество элеиентов массива в отрезке [10,99] = " + count);

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
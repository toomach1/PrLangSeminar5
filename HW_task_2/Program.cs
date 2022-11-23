// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] arr = GetRandomArray(4, -99, +99);

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + arr[i];
    }
}

PrintArray(arr);

System.Console.WriteLine();

System.Console.WriteLine($"сумма нечетных элементов в массиве = {sum}");

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
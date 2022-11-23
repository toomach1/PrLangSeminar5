// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = GetRandomArray(10, 99, 1000);

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2 == 0)
    {
        count ++;
    }
}

PrintArray(arr);

System.Console.WriteLine();

System.Console.WriteLine($"количесвто четных чисел в массиве = {count}");


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
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int[] arr = GetRandomArray(7, 1, 10);

int size = arr.Length % 2 == 0? arr.Length/2 : (arr.Length/2)+1;

int[] arrNew = new int[size];

System.Console.WriteLine(String.Join(",", arr));

for (int i = 0; i < arr.Length/2; i++)
{
   
    arrNew[i] = arr[i] * arr[arr.Length - i - 1];
    
}

if (arr.Length % 2 != 0)
{
    arrNew[size-1] = arr[size - 1];
}

// PrintArray(arr);

System.Console.WriteLine(String.Join(",", arrNew));

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

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
// }
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

int size = 12;

int[] arr = GetRandomArray(size, -9, 9);

PrintArray(arr);

int negativeSum = GetSum(arr, false);

int positiveSum = GetSum(arr);

System.Console.WriteLine("positive ="+positiveSum);

System.Console.WriteLine("negative ="+negativeSum);

int GetSum(int[] arr, bool isPositiv = true)
{
    if (isPositiv)
    {
        return GetPositivSum(arr);
    }
    else
    {
        return GetNegativSum(arr);
    }
}

int GetPositivSum(int[] arr)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            sum+=arr[i];
        }
    }
    return sum;
}

int GetNegativSum(int[] arr)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<0)
        {
            sum+=arr[i];
        }
    }
    return sum;
}

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int [size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last+1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      System.Console.Write(arr[i]+ " ");  
    }
}
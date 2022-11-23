//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = GetRandomArray(10, -99, 100);

double difference = GetDifference(arr);

PrintArray(arr);

System.Console.WriteLine("разница между максимальным и минимальным элементов массива = " + difference);

double[] GetRandomArray(int size, int begin, int last)
{
    double[] res = new double[size];

    var random = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = random.Next(begin, last + 1);// + random.NextDouble();
    }

    return res;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array) //посмотрел в обсуждении дз, сначла не понял, потом почитал про "foreach" и разобрался
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return (max - min);
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int count = 10;
 
int[] arr = InitialArr(count);

PrintArray(arr);

int[] ReversArr = ReverseArr(arr);

System.Console.WriteLine();

PrintArray(ReversArr);


int[] ReverseArr(int[] arr)
{
    int[] reversarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        reversarr[i] = arr[i]*(-1);
    }
    return reversarr;
}

int[] InitialArr(int count)
{
    Random rand = new Random();
    int [] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9,10);
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
// Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.

int[] arr = InitialArr(10);



System.Console.WriteLine("input number");

int num = Convert.ToInt32(Console.ReadLine());

if (CheckDigit(arr, num))
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
// CheckDigit(arr, num);

PrintArray(arr);


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

bool CheckDigit(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==Math.Abs(value))
        {
            
            return true;
        }
        
    }
    return false;
}

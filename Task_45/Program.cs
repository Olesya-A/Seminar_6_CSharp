// 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = { 5, 6, 7, 8, 9,10 };
int[] CopyArray = GetCopyArray(array);
PrintArray(CopyArray);

int[] GetCopyArray(int[] array)
{
    int size = array.Length;
    int[] CopyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        CopyArray[i] = array[i];
    }
    return CopyArray;
}


void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}




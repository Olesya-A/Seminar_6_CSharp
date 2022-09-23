//39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Array.Reverse(numbers); 

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
PrintArray(numbers);
ReverseArray(numbers);
PrintArray(numbers);

void Swap(ref int a, ref int b) // ref - передаем значение по ссылке
{
    int c = a;
    a = b;
    b = c;
}

void PrintArray(int[] numbers) => Console.WriteLine(String.Join(", ", numbers)); //c#6 функция состоящая из одного действия


void ReverseArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        int j = numbers.Length - 1 - i;   // ^(i+1) - альтернативная запись, отсчитывание элементов с конца
        Swap(ref numbers[i], ref numbers[j]);
    }
}
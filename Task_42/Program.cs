// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// РЕШЕНИЕ С ЦИКЛОМ WHILE

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
Console.Write(ConvertTo2(number));

string ConvertTo2(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = $"{number % 2}{result}";
        number = number / 2;
    }
    return result;
}

// РЕШЕНИЕ С РЕКУРСИЕЙ

// Console.Write("Введите число : ");
// int number = int.Parse(Console.ReadLine()!);
// Console.Write(ConvertTo2Rec(number));

// string ConvertTo2Rec(int number)
// {
//     string result = string.Empty;
//     if (number > 0)
//     {
//         string res = ConvertTo2Rec(number / 2);

//         result = $"{res}{number % 2}";

//         return result;
//     }
//     else return "";

// }

// РЕШЕНИЕ С РЕКУРСИЕЙ УЛУЧШЕННОЕ

// Console.Write("Введите число : ");
// int number = int.Parse(Console.ReadLine()!);
// Console.Write(ConvertTo2Rec(number));

// string ConvertTo2Rec(int number)
// {
//    if (number == 0)
//     {
//        return "";
//     }
//     return $"{ConvertTo2Rec(number / 2)}{number % 2}";
// }

// Еще оин вариант решения

// Console.Write("Input integer number: ");
// int num = int.Parse(Console.ReadLine()!);

// Console.WriteLine(ConvTo2(num));

// string ConvTo2(int num)
// {
//     string result = "";

//     while (num > 0)
//         {
//             string substring = $"{num % 2}";
//             result = result.Insert(0, substring);
//             num = num / 2;
//         }
//     return result;
// }
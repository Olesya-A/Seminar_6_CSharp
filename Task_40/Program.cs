// 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите 3 числа через пробел: ");
string input = Console.ReadLine()!;
string[] numbers = input.Split(' ');
int a = int.Parse(numbers[0]);
int b = int.Parse(numbers[1]);
int c = int.Parse(numbers[2]);

if (DoesTriangleExist(a, b, c))
{
    Console.WriteLine("yes");
}
else Console.WriteLine("no");


bool DoesTriangleExist(int a, int b, int c)
{
    return a < b + a && b < a + c && c < a + b;
}
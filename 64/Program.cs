// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое число M: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число N: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if(!isNumberM || !isNumberN || m < 1 || n < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Recursion(m, n);



void Recursion(int m, int n)
{
    if (m == n + 1)
    {
        return;
    }
    Console.Write($"{m} ");
    Recursion(++m, n);
}
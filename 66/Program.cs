// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите первое число M: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число N: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if(!isNumberM || !isNumberN || m < 1 || n < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Console.WriteLine($"Сумма: {FindSum(m, n)}");



int FindSum(int m, int n)
{
    if (m == n + 1)
    {
        return 0;
    }

    return m + FindSum(++m, n);
}
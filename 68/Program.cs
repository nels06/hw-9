// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите первое число M: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число N: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || !isNumberN || m < 0 || n < 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Console.WriteLine($"Сумма: {FindAckermanFunction(m, n)}");



int FindAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return FindAckermanFunction(m - 1, 1);
    }

    return FindAckermanFunction(m - 1, FindAckermanFunction(m, n - 1));
}